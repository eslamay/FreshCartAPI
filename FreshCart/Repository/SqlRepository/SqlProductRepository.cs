using FreshCart.Data;
using FreshCart.Models.Domain;
using FreshCart.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace FreshCart.Repository.SqlRepository
{
	public class SqlProductRepository : IProductRepository
	{
		private readonly ApplicationDbContext dbContext;

		public SqlProductRepository(ApplicationDbContext dbContext)
		{
			this.dbContext = dbContext;
		}
		public async Task<List<Product>> GetAllAsync(string? sortBy = null, string? categoryName = null, int pageNumber = 1, int pageSize = 20)
		{
			var productsQuery = dbContext.Products
				.Include(p => p.Category)
				.Include(p => p.SubCategory)
				.Include(p => p.Brand)
				.AsQueryable();

			// choosing products by category type
			if (!string.IsNullOrEmpty(categoryName?.ToLower()))
			{
				productsQuery = productsQuery.Where(p => p.Category.Name == categoryName);
			}

				//sorting by
				if (!string.IsNullOrEmpty(sortBy))
			{
				switch (sortBy.ToLower())
				{
					case "lowest-price": 
						productsQuery = productsQuery.OrderBy(p => p.Price);
						break;
					case "highest-price": 
						productsQuery = productsQuery.OrderByDescending(p => p.Price);
						break;
					case "lowest-rating": 
						productsQuery = productsQuery.OrderBy(p => p.RatingsAverage);
						break;
					case "highest-rating": 
						productsQuery = productsQuery.OrderByDescending(p => p.RatingsAverage);
						break;
					case "bestseller": 
						productsQuery = productsQuery.OrderByDescending(p => p.Sold);
						break;
					default:
						break;
				}
			}
			//  Pagination
			int totalCount = await productsQuery.CountAsync();

			productsQuery = productsQuery
				.Skip((pageNumber - 1) * pageSize); // تخطي المنتجات السابقة

			return await productsQuery.ToListAsync();

		}

		public async Task<Product?> GetByIdAsync(Guid id)
		{
			return await dbContext.Products
				.Include(p => p.Category)
				.Include(p => p.SubCategory)
				.Include(p => p.Brand)
				.FirstOrDefaultAsync(p => p.Id == id);
		}
		public async Task<Product> CreateAsync(Product product)
		{
			product.Id = Guid.NewGuid();
			product.CreatedAt = DateTime.Now;
			product.UpdatedAt = DateTime.Now;

			await dbContext.Products.AddAsync(product);
			await dbContext.SaveChangesAsync();
			return product; 
		}

		public async Task<Product?> UpdateAsync(Guid id, Product product)
		{
			var existingProduct = await dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
			if (existingProduct == null)
			{
				return null;
			}

			dbContext.Entry(existingProduct).CurrentValues.SetValues(product);
			existingProduct.UpdatedAt = DateTime.Now;

			await dbContext.SaveChangesAsync();
			return existingProduct;
		}
		public async Task<Product> DeleteAsync(Guid id)
		{
			var product = await dbContext.Products.FirstOrDefaultAsync(p => p.Id == id);
			if (product == null)
			{
				return null;
			}

			if (!string.IsNullOrEmpty(product.ImageCoverUrl))
			{
				var coverFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ProductImages", Path.GetFileName(product.ImageCoverUrl.Split('/').Last()));
				if (File.Exists(coverFilePath))
				{
					File.Delete(coverFilePath);
				}
			}

			if (product.ImagesUrl != null && product.ImagesUrl.Count > 0)
			{
				foreach (var imageUrl in product.ImagesUrl)
				{
					var imageFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ProductImages", Path.GetFileName(imageUrl.Split('/').Last()));
					if (File.Exists(imageFilePath))
					{
						File.Delete(imageFilePath);
					}
				}
			}

			dbContext.Products.Remove(product);
			await dbContext.SaveChangesAsync();
			return product;
		}

	}
}
