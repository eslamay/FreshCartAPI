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
	public class WishListController : ControllerBase
	{
        private readonly IWishlistRepository wishlistRepository;
		private readonly IProductRepository productRepository;
		private readonly IMapper mapper;

		public WishListController(
			IWishlistRepository wishlistRepository,
			IProductRepository productRepository,
			IMapper mapper)
		{
			this.wishlistRepository = wishlistRepository;
			this.productRepository = productRepository;
			this.mapper = mapper;
		}

		
		[HttpPost]
		[ValidateModel]
		public async Task<IActionResult> AddToWishlist([FromBody] AddWishlistDto addWishlistDto)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var product = await productRepository.GetByIdAsync(addWishlistDto.ProductId);
			if (product == null)
			{
				return NotFound("Product not found.");
			}

			if (await wishlistRepository.ExistsInWishlistAsync(userId, addWishlistDto.ProductId))
			{
				return BadRequest("Product already exists in your wishlist.");
			}

			var wishlistItem = await wishlistRepository.AddToWishlistAsync(userId, addWishlistDto.ProductId);
			var wishlistDto = mapper.Map<WishlistDto>(wishlistItem);
			wishlistDto.Product = mapper.Map<ProductDto>(product);

			return Ok(wishlistDto);
		}

		
		[HttpDelete]
		[Route("{productId:Guid}")]
		public async Task<IActionResult> RemoveFromWishlist(Guid productId)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var removed = await wishlistRepository.RemoveFromWishlistAsync(userId, productId);
			if (!removed)
			{
				return NotFound("Product not found in your wishlist.");
			}

			return Ok(new { message = "Product removed from wishlist." });
		}

		
		[HttpGet]
		public async Task<IActionResult> GetWishlist()
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var wishlistItems = await wishlistRepository.GetWishlistAsync(userId);
			var wishlistDtos = mapper.Map<List<WishlistDto>>(wishlistItems);

			return Ok(wishlistDtos);
		}
	}
}

