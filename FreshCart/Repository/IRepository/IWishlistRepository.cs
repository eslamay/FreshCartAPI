using FreshCart.Models.Domain;

namespace FreshCart.Repository.IRepository
{
	public interface IWishlistRepository
	{
		Task<Wishlist> AddToWishlistAsync(string userId, Guid productId);
		Task<bool> RemoveFromWishlistAsync(string userId, Guid productId);
		Task<List<Wishlist>> GetWishlistAsync(string userId);
		Task<bool> ExistsInWishlistAsync(string userId, Guid productId);
	}
}
