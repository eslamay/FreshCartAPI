using AutoMapper;
using FreshCart.CustomActionFilters;
using FreshCart.Models.Domain;
using FreshCart.Models.DTO;
using FreshCart.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreshCart.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly IOrderRepository orderRepository;
		private readonly IAddressRepository addressRepository;
		private readonly IMapper mapper;

		public OrdersController(
			IOrderRepository orderRepository,
			IAddressRepository addressRepository,
			IMapper mapper)
		{
			this.orderRepository = orderRepository;
			this.addressRepository = addressRepository;
			this.mapper = mapper;
		}

		//  Create Cash Order
		[HttpPost]
		[Route("cash")]
		[ValidateModel]
		public async Task<IActionResult> CreateCashOrder([FromBody] CreateOrderDto createOrderDto)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			try
			{
				var order = await orderRepository.CreateCashOrderAsync(userId, createOrderDto.ShippingAddressId);
				var orderDto = mapper.Map<OrderDto>(order);
				PopulateOrderItems(order, orderDto);
				return Ok(orderDto);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		// Get all orders (Admin only)
		[HttpGet]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> GetAllOrders()
		{
			var orders = await orderRepository.GetAllOrdersAsync();
			var orderDtos = mapper.Map<List<OrderDto>>(orders);
			foreach (var orderDto in orderDtos)
			{
				var order = orders.First(o => o.Id == orderDto.Id);
				PopulateOrderItems(order, orderDto);
			}
			return Ok(orderDtos);
		}

		//  Get user orders
		[HttpGet]
		[Route("my-orders")]
		public async Task<IActionResult> GetUserOrders()
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var orders = await orderRepository.GetUserOrdersAsync(userId);
			var orderDtos = mapper.Map<List<OrderDto>>(orders);
			foreach (var orderDto in orderDtos)
			{
				var order = orders.First(o => o.Id == orderDto.Id);
				PopulateOrderItems(order, orderDto);
			}
			return Ok(orderDtos);
		}

		//  Checkout session
		[HttpPost]
		[Route("checkout-session")]
		[ValidateModel]
		public async Task<IActionResult> CreateCheckoutSession([FromBody] CheckoutSessionDto checkoutSessionDto)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var address = await addressRepository.GetAddressByIdAsync(userId, checkoutSessionDto.ShippingAddressId);
			if (address == null)
			{
				return NotFound("Shipping address not found.");
			}
		
			//payment logic here later....

			var response = new CheckoutResponseDto
			{
				SessionId = Guid.NewGuid().ToString(),
				ShippingAddress = new ShippingAddressResponseDto
				{
					Details = address.Details,
					Phone = address.Phone,
					City = address.City
				}
			};

			return Ok(response);
		}

		private void PopulateOrderItems(Order order, OrderDto orderDto)
		{
			orderDto.Items = mapper.Map<List<OrderItemDto>>(order.Items);
			foreach (var item in orderDto.Items)
			{
				var product = order.Items.First(i => i.Id == item.Id).Product;
				item.ProductTitle = product.Title;
				item.TotalPrice = item.Price * item.Quantity;
			}
		}
	}
}
