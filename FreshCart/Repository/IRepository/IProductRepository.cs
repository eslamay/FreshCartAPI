using FreshCart.Models.Domain;

namespace FreshCart.Repository.IRepository
{
	public interface IProductRepository
	{
		Task<List<Product>> GetAllAsync(string? sortBy = null, string? categoryName = null, int pageNumber = 1, int pageSize = 20);
		Task<Product?> GetByIdAsync(Guid id);
		Task<Product> CreateAsync(Product product);
		Task<Product?> UpdateAsync(Guid id, Product product);
		Task<Product?> DeleteAsync(Guid id);
	}
}
