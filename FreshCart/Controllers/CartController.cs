using AutoMapper;
using FreshCart.CustomActionFilters;
using FreshCart.Models.DTO;
using FreshCart.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreshCart.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartController : ControllerBase
	{
		private readonly ICartRepository cartRepository;
		private readonly IProductRepository productRepository;
		private readonly IMapper mapper;

		public CartController(
			ICartRepository cartRepository,
			IProductRepository productRepository,
			IMapper mapper)
		{
			this.cartRepository = cartRepository;
			this.productRepository = productRepository;
			this.mapper = mapper;
		}

		//  Add product to cart
		[HttpPost]
		[ValidateModel]
		public async Task<IActionResult> AddToCart([FromBody] AddCartItemDto addCartItemDto)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var product = await productRepository.GetByIdAsync(addCartItemDto.ProductId);
			if (product == null)
			{
				return NotFound("Product not found.");
			}

			var cartItem = await cartRepository.AddToCartAsync(userId, addCartItemDto.ProductId, addCartItemDto.Quantity);
			var cartItemDto = mapper.Map<CartItemDto>(cartItem);
			cartItemDto.ProductTitle = product.Title;
			cartItemDto.ProductPrice = product.Price;
			cartItemDto.ImageCoverUrl = product.ImageCoverUrl;
			cartItemDto.TotalPrice = product.Price * cartItem.Quantity;

			return Ok(cartItemDto);
		}

		// Update cart product quantity
		[HttpPut]
		[Route("{cartItemId:Guid}")]
		[ValidateModel]
		public async Task<IActionResult> UpdateCartItemQuantity(Guid cartItemId, [FromBody] UpdateCartItemDto updateCartItemDto)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var cartItem = await cartRepository.UpdateCartItemQuantityAsync(userId, cartItemId, updateCartItemDto.Quantity);
			if (cartItem == null)
			{
				return NotFound("Cart item not found.");
			}

			var product = await productRepository.GetByIdAsync(cartItem.ProductId);
			var cartItemDto = mapper.Map<CartItemDto>(cartItem);
			cartItemDto.ProductTitle = product.Title;
			cartItemDto.ProductPrice = product.Price;
			cartItemDto.ImageCoverUrl = product.ImageCoverUrl;
			cartItemDto.TotalPrice = product.Price * cartItem.Quantity;

			return Ok(cartItemDto);
		}

		//  Get logged user cart
		[HttpGet]
		public async Task<IActionResult> GetCart()
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var cart = await cartRepository.GetCartAsync(userId);
			if (cart == null || !cart.Items.Any())
			{
				return Ok(new CartDto { Id = Guid.Empty, Items = new List<CartItemDto>(), TotalCartPrice = 0 });
			}

			var cartDto = new CartDto
			{
				Id = cart.Id,
				Items = mapper.Map<List<CartItemDto>>(cart.Items)
			};

			foreach (var item in cartDto.Items)
			{
				var product = cart.Items.First(i => i.Id == item.Id).Product;
				item.ProductTitle = product.Title;
				item.ProductPrice = product.Price;
				item.ImageCoverUrl = product.ImageCoverUrl;
				item.TotalPrice = product.Price * item.Quantity;
			}

			cartDto.TotalCartPrice = cartDto.Items.Sum(i => i.TotalPrice);
			return Ok(cartDto);
		}

		//  Remove specific cart item
		[HttpDelete]
		[Route("{cartItemId:Guid}")]
		public async Task<IActionResult> RemoveCartItem(Guid cartItemId)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var removed = await cartRepository.RemoveCartItemAsync(userId, cartItemId);
			if (!removed)
			{
				return NotFound("Cart item not found.");
			}

			return Ok(new { message = "Cart item removed successfully." });
		}

		//  Clear user cart
		[HttpDelete]
		[Route("clear")]
		public async Task<IActionResult> ClearCart()
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var cleared = await cartRepository.ClearCartAsync(userId);
			if (!cleared)
			{
				return NotFound("Cart is already empty or not found.");
			}

			return Ok(new { message = "Cart cleared successfully." });
		}
	}
}
