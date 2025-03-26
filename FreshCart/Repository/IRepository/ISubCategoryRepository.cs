using FreshCart.Models.Domain;

namespace FreshCart.Repository.IRepository
{
	public interface ISubCategoryRepository
	{
		Task<List<SubCategory>> GetAllAsync();
		Task<SubCategory?> GetByIdAsync(Guid id);
        Task<List<SubCategory>> GetAllByCategoryIdAsync(Guid categoryId);
		Task<SubCategory> CreateAsync(SubCategory category);

		Task<bool> ExistsAsync(Guid categoryId);
		Task<SubCategory?> UpdateAsync(Guid id, SubCategory category);
		Task<SubCategory?> DeleteAsync(Guid id);
	}
}
