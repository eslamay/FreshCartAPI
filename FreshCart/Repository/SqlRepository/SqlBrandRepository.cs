using FreshCart.Data;
using FreshCart.Models.Domain;
using FreshCart.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FreshCart.Repository.SqlRepository
{
	public class SqlBrandRepository : IBrandRepository
	{
		private readonly ApplicationDbContext dbContext;

		public SqlBrandRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public async Task<List<Brand>> GetAllAsync()
		{
			return await dbContext.Brands.ToListAsync();
		}

		public async Task<Brand?> GetByIdAsync(Guid id)
		{
			return await dbContext.Brands.FindAsync(id);
		}
		public async Task<Brand> CreateAsync(Brand brand)
		{
			await dbContext.Brands.AddAsync(brand);
			await dbContext.SaveChangesAsync();
			return brand;
		}

		public async Task<Brand?> UpdateAsync(Guid id, Brand brand)
		{
			var existingBrand = await dbContext.Brands.FindAsync(id);
			if (existingBrand == null)
			{
				return null;
			}

			existingBrand.Name = brand.Name;
			existingBrand.Slug = brand.Slug;
			existingBrand.UpdatedAt = DateTime.UtcNow;


			if (!string.IsNullOrEmpty(existingBrand.ImageUrl) && !string.IsNullOrEmpty(existingBrand.ImageUrl))
			{
				var oldImagePath = Path.Combine("wwwroot", existingBrand.ImageUrl.TrimStart('/'));
				if (File.Exists(oldImagePath))
				{
					File.Delete(oldImagePath);
				}

				existingBrand.ImageUrl = brand.ImageUrl;
			}

			await dbContext.SaveChangesAsync();
			return existingBrand;
		}
		public async Task<Brand?> DeleteAsync(Guid id)
		{
			var existingBrand = await dbContext.Brands.FindAsync(id);

			if (existingBrand == null)
			{
				return null;
			}

			if (!string.IsNullOrEmpty(existingBrand.ImageUrl))
			{
				var imagePath = Path.Combine("wwwroot", existingBrand.ImageUrl.TrimStart('/'));
				if (File.Exists(imagePath))
				{
					File.Delete(imagePath);
				}
			}

			dbContext.Brands.Remove(existingBrand);
			await dbContext.SaveChangesAsync();
			return existingBrand;
		}


	}
}
