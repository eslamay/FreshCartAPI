using FreshCart.Models.Domain;

namespace FreshCart.Repository.IRepository
{
	public interface IAddressRepository
	{
		Task<Address> AddAddressAsync(string userId, Address address);
		Task<bool> RemoveAddressAsync(string userId, Guid addressId);
		Task<Address> GetAddressByIdAsync(string userId, Guid addressId);
		Task<List<Address>> GetUserAddressesAsync(string userId);
	}
}
