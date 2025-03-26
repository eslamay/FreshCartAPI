using FreshCart.Models.Domain;

namespace FreshCart.Repository.IRepository
{
	public interface IOrderRepository
	{
		Task<Order> CreateCashOrderAsync(string userId, Guid shippingAddressId);
		Task<List<Order>> GetAllOrdersAsync();
		Task<List<Order>> GetUserOrdersAsync(string userId);
	}
}
