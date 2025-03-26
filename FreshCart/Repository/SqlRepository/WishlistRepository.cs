using FreshCart.Data;
using FreshCart.Models.Domain;
using FreshCart.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreshCart.Repository
{
	public class WishlistRepository : IWishlistRepository
	{
		private readonly ApplicationDbContext dbContext;

		public WishlistRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<Wishlist> AddToWishlistAsync(string userId, Guid productId)
		{
			var wishlistItem = new Wishlist
			{
				Id = Guid.NewGuid(),
				UserId = userId,
				ProductId = productId,
				AddedAt = DateTime.Now
			};

			await dbContext.Wishlist.AddAsync(wishlistItem);
			await dbContext.SaveChangesAsync();
			return wishlistItem;
		}

		public async Task<bool> RemoveFromWishlistAsync(string userId, Guid productId)
		{
			var wishlistItem = await dbContext.Wishlist
				.FirstOrDefaultAsync(w => w.UserId == userId && w.ProductId == productId);

			if (wishlistItem == null) return false;

			dbContext.Wishlist.Remove(wishlistItem);
			await dbContext.SaveChangesAsync();
			return true;
		}

		public async Task<List<Wishlist>> GetWishlistAsync(string userId)
		{
			return await dbContext.Wishlist
				.Include(w => w.Product) .Include(w=>w.Product.Category).Include(w => w.Product.SubCategory).Include(w => w.Product.Brand)
				.Where(w => w.UserId == userId)
				.ToListAsync();
		}

		public async Task<bool> ExistsInWishlistAsync(string userId, Guid productId)
		{
			return await dbContext.Wishlist
				.AnyAsync(w => w.UserId == userId && w.ProductId == productId);
		}
	}
}