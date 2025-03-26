using FreshCart.Data;
using FreshCart.Models.Domain;
using FreshCart.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FreshCart.Repository.SqlRepository
{
	public class OrderRepository: IOrderRepository
	{
		private readonly ApplicationDbContext dbContext;
		private readonly ICartRepository cartRepository;
		private readonly IAddressRepository addressRepository;

		public OrderRepository(
			ApplicationDbContext dbContext,
			ICartRepository cartRepository,
			IAddressRepository addressRepository)
		{
			this.dbContext = dbContext;
			this.cartRepository = cartRepository;
			this.addressRepository = addressRepository;
		}

		public async Task<Order> CreateCashOrderAsync(string userId, Guid shippingAddressId)
		{
			var cart = await cartRepository.GetCartAsync(userId);
			if (cart == null || !cart.Items.Any())
			{
				throw new Exception("Cart is empty.");
			}

			var address = await addressRepository.GetAddressByIdAsync(userId, shippingAddressId);
			if (address == null)
			{
				throw new Exception("Shipping address not found.");
			}

			var order = new Order
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				TotalPrice = cart.Items.Sum(i => i.Quantity * i.Product.Price),
				ShippingDetails = address.Details,
				ShippingPhone = address.Phone,
				ShippingCity = address.City,
				PaymentMethod = "Cash",
				Items = cart.Items.Select(i => new OrderItem
				{
					Id = Guid.NewGuid(),
					ProductId = i.ProductId,
					Quantity = i.Quantity,
					Price = i.Product.Price
				}).ToList()
			};

			await dbContext.Orders.AddAsync(order);
			await cartRepository.ClearCartAsync(userId); // تفريغ السلة بعد الطلب
			await dbContext.SaveChangesAsync();

			return order;
		}

		public async Task<List<Order>> GetAllOrdersAsync()
		{
			return await dbContext.Orders
				.Include(o => o.Items)
				.ThenInclude(oi => oi.Product)
				.ToListAsync();
		}

		public async Task<List<Order>> GetUserOrdersAsync(string userId)
		{
			return await dbContext.Orders
				.Include(o => o.Items)
				.ThenInclude(oi => oi.Product)
				.Where(o => o.UserId == userId)
				.ToListAsync();
		}
	}
}
