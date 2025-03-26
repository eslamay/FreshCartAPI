using FreshCart.Data;
using FreshCart.Models.Domain;
using FreshCart.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FreshCart.Repository.SqlRepository
{
	public class SqlSubCategoryRepository : ISubCategoryRepository
	{
		private readonly ApplicationDbContext dbContext;

		public SqlSubCategoryRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public async Task<List<SubCategory>> GetAllAsync()
		{
			return await dbContext.SubCategories.ToListAsync();
		}

		public async Task<List<SubCategory>> GetAllByCategoryIdAsync(Guid categoryId)
		{
			var categoryExists = await dbContext.Categories.AnyAsync(c => c.Id == categoryId);
			if (!categoryExists)
				return null!;

			return await dbContext.SubCategories
			.Where(sc => sc.CategoryId == categoryId)
			.ToListAsync();
		}

		public async Task<SubCategory?> GetByIdAsync(Guid id)
		{
			return await dbContext.SubCategories.FindAsync(id);
		}

		public async Task<SubCategory> CreateAsync(SubCategory subCategory)
		{
			await dbContext.SubCategories.AddAsync(subCategory);
			await dbContext.SaveChangesAsync();
			return subCategory;
		}

		public async Task<SubCategory?> UpdateAsync(Guid id, SubCategory subCategory)
		{
			var existingSubCategory = await dbContext.SubCategories.FindAsync(id);

			if (existingSubCategory == null)
				return null;

			var categoryExists = await dbContext.Categories.AnyAsync(c => c.Id == subCategory.CategoryId);
			if (!categoryExists)
				return null;

			existingSubCategory.Name = subCategory.Name;
			existingSubCategory.CategoryId = subCategory.CategoryId;
			existingSubCategory.UpdatedAt = DateTime.UtcNow;

			await dbContext.SaveChangesAsync();
			return existingSubCategory;
		}

		public async Task<SubCategory?> DeleteAsync(Guid id)
		{
			var subCategory = await dbContext.SubCategories.FindAsync(id);

			if (subCategory == null)
				return null; 

			dbContext.SubCategories.Remove(subCategory);
			await dbContext.SaveChangesAsync();
			return subCategory;
		}

		public async Task<bool> ExistsAsync(Guid categoryId)
		{
			return await dbContext.Categories.AnyAsync(c => c.Id == categoryId);
		}
	}
}
