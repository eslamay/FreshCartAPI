using FreshCart.Data;
using FreshCart.Models.Domain;
using FreshCart.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FreshCart.Repository.SqlRepository
{
	public class AddressRepository: IAddressRepository
	{
		private readonly ApplicationDbContext dbContext;

		public AddressRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<Address> AddAddressAsync(string userId, Address address)
		{
			address.Id = Guid.NewGuid();
			address.UserId = userId;
			await dbContext.Addresses.AddAsync(address);
			await dbContext.SaveChangesAsync();
			return address;
		}

		public async Task<bool> RemoveAddressAsync(string userId, Guid addressId)
		{
			var address = await dbContext.Addresses
				.FirstOrDefaultAsync(a => a.UserId == userId && a.Id == addressId);

			if (address == null) return false;

			dbContext.Addresses.Remove(address);
			await dbContext.SaveChangesAsync();
			return true;
		}

		public async Task<Address> GetAddressByIdAsync(string userId, Guid addressId)
		{
			return await dbContext.Addresses
				.FirstOrDefaultAsync(a => a.UserId == userId && a.Id == addressId);
		}

		public async Task<List<Address>> GetUserAddressesAsync(string userId)
		{
			return await dbContext.Addresses
				.Where(a => a.UserId == userId)
				.ToListAsync();
		}
	}
}
