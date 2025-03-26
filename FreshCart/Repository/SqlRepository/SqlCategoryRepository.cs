using FreshCart.Data;
using FreshCart.Models.Domain;
using FreshCart.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FreshCart.Repository.SqlRepository
{
	public class SqlCategoryRepository : ICategoryRepository
	{
		private readonly ApplicationDbContext dbContext;

		public SqlCategoryRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<List<Category>> GetAllAsync()
		{
			return await dbContext.Categories.ToListAsync();
		}

		public async Task<Category?> GetByIdAsync(Guid id)
		{
			return await dbContext.Categories.FindAsync(id);
		}

		public async Task<Category> CreateAsync(Category category)
		{
			await dbContext.Categories.AddAsync(category);
			await dbContext.SaveChangesAsync();
			return category;
		}

		public async Task<Category?> UpdateAsync(Guid id, Category category)
		{
			var existingCategory = await dbContext.Categories.FindAsync(id);
			if (existingCategory == null)
			{
				return null;
			}

			existingCategory.Name = category.Name;
			existingCategory.Slug = category.Slug;
			existingCategory.UpdatedAt = DateTime.UtcNow;


			if (!string.IsNullOrEmpty(existingCategory.ImageUrl) && !string.IsNullOrEmpty(existingCategory.ImageUrl))
			{
				var oldImagePath = Path.Combine("wwwroot", existingCategory.ImageUrl.TrimStart('/'));
				if (File.Exists(oldImagePath))
				{
					File.Delete(oldImagePath);
				}

				existingCategory.ImageUrl = category.ImageUrl;
			}

			await dbContext.SaveChangesAsync();
			return existingCategory;
		}
		public async Task<Category?> DeleteAsync(Guid id)
		{
			var existingCategory = await dbContext.Categories.FindAsync(id);

			if (existingCategory == null)
			{
				return null;
			}

			if (!string.IsNullOrEmpty(existingCategory.ImageUrl))
			{
				var imagePath = Path.Combine("wwwroot", existingCategory.ImageUrl.TrimStart('/'));
				if (File.Exists(imagePath))
				{
					File.Delete(imagePath);
				}
			}

			dbContext.Categories.Remove(existingCategory);
			await dbContext.SaveChangesAsync();
			return existingCategory;
		}

	}
}
