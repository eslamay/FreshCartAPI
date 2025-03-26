using FreshCart.Data;
using FreshCart.Models.Domain;
using FreshCart.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FreshCart.Repository.SqlRepository
{
	public class CartRepository:ICartRepository
	{
		private readonly ApplicationDbContext dbContext;

		public CartRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<Cart> GetOrCreateCartAsync(string userId)
		{
			var cart = await dbContext.Carts
				.Include(c => c.Items)
				.ThenInclude(ci => ci.Product)
				.FirstOrDefaultAsync(c => c.UserId == userId);

			if (cart == null)
			{
				cart = new Cart
				{
					Id = Guid.NewGuid(),
					UserId = userId
				};
				await dbContext.Carts.AddAsync(cart);
				await dbContext.SaveChangesAsync();
			}

			return cart;
		}

		public async Task<CartItem> AddToCartAsync(string userId, Guid productId, int quantity)
		{
			var cart = await GetOrCreateCartAsync(userId);

			var existingItem = cart.Items.FirstOrDefault(i => i.ProductId == productId);
			if (existingItem != null)
			{
				existingItem.Quantity += quantity;
				dbContext.CartItems.Update(existingItem);
			}
			else
			{
				var cartItem = new CartItem
				{
					Id = Guid.NewGuid(),
					CartId = cart.Id,
					ProductId = productId,
					Quantity = quantity
				};
				cart.Items.Add(cartItem);
				await dbContext.CartItems.AddAsync(cartItem);
			}

			await dbContext.SaveChangesAsync();
			return cart.Items.First(i => i.ProductId == productId);
		}

		public async Task<CartItem> UpdateCartItemQuantityAsync(string userId, Guid cartItemId, int quantity)
		{
			var cart = await GetOrCreateCartAsync(userId);
			var cartItem = cart.Items.FirstOrDefault(i => i.Id == cartItemId);

			if (cartItem == null) return null;

			cartItem.Quantity = quantity;
			dbContext.CartItems.Update(cartItem);
			await dbContext.SaveChangesAsync();
			return cartItem;
		}

		public async Task<Cart> GetCartAsync(string userId)
		{
			return await dbContext.Carts
				.Include(c => c.Items)
				.ThenInclude(ci => ci.Product)
				.FirstOrDefaultAsync(c => c.UserId == userId);
		}

		public async Task<bool> RemoveCartItemAsync(string userId, Guid cartItemId)
		{
			var cart = await GetOrCreateCartAsync(userId);
			var cartItem = cart.Items.FirstOrDefault(i => i.Id == cartItemId);

			if (cartItem == null) return false;

			cart.Items.Remove(cartItem);
			dbContext.CartItems.Remove(cartItem);
			await dbContext.SaveChangesAsync();
			return true;
		}

		public async Task<bool> ClearCartAsync(string userId)
		{
			var cart = await GetCartAsync(userId);
			if (cart == null || !cart.Items.Any()) return false;

			dbContext.CartItems.RemoveRange(cart.Items);
			cart.Items.Clear();
			await dbContext.SaveChangesAsync();
			return true;
		}
	}
}
