using FreshCart.Models.Domain;

namespace FreshCart.Repository.IRepository
{
	public interface ICartRepository
	{
		Task<Cart> GetOrCreateCartAsync(string userId);
		Task<CartItem> AddToCartAsync(string userId, Guid productId, int quantity);
		Task<CartItem> UpdateCartItemQuantityAsync(string userId, Guid cartItemId, int quantity);
		Task<Cart> GetCartAsync(string userId);
		Task<bool> RemoveCartItemAsync(string userId, Guid cartItemId);
		Task<bool> ClearCartAsync(string userId);
	}
}
