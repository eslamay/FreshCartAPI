using FreshCart.Models.Domain;

namespace FreshCart.Repository.IRepository
{
	public interface IBrandRepository
	{
		Task<List<Brand>> GetAllAsync();
		Task<Brand?> GetByIdAsync(Guid id);
		Task<Brand> CreateAsync(Brand brand);
		Task<Brand?> UpdateAsync(Guid id, Brand brand);
		Task<Brand?> DeleteAsync(Guid id);
	}
}
