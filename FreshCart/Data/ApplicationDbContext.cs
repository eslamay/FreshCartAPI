using FreshCart.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreshCart.Data
{
	public class ApplicationDbContext:IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
		{

		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Brand> Brands { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
		public DbSet<Wishlist> Wishlist { get; set; }
		public DbSet<Address> Addresses { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderItem> OrderItems { get; set; }
	}

	//		protected override void OnModelCreating(ModelBuilder modelBuilder)
	//		{
	//			base.OnModelCreating(modelBuilder);

	//			modelBuilder.Entity<Category>().HasData(
	//				new Category
	//				{
	//					Id = Guid.Parse("7bbb9a6e-27f2-49ca-a62a-59f04c940090"),
	//					Name = "Music",
	//					Slug = "music",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511964020.jpeg",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				},
	//				new Category
	//				{
	//					Id = Guid.Parse("40d9125c-01b3-4084-b60f-2a4fee924765"),
	//					Name = "Men's Fashion",
	//					Slug = "men's-fashion",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511865180.jpeg",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				},
	//				new Category
	//				{
	//					Id = Guid.Parse("046a4dd7-9529-4de1-bcd9-25e1f188577d"),
	//					Name = "Women's Fashion",
	//					Slug = "women's-fashion",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511818071.jpeg",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				},
	//				new Category
	//				{
	//					Id = Guid.Parse("451bbac9-4ae4-4c3d-a957-5c855af41d26"),
	//					Name = "SuperMarket",
	//					Slug = "supermarket",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511452254.png",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				},
	//				new Category
	//				{
	//					Id = Guid.Parse("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"),
	//					Name = "Baby & Toys",
	//					Slug = "baby-and-toys",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511427130.png",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				},
	//				new Category
	//				{
	//					Id = Guid.Parse("67f73162-8eff-43fe-b693-3951a800b20d"),
	//					Name = "Home",
	//					Slug = "home",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511392672.png",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				},
	//				new Category
	//				{
	//					Id = Guid.Parse("b39860b5-91b7-41dd-b52b-22d2ee9c4ec4"),
	//					Name = "Books",
	//					Slug = "books",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511368164.png",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				},
	//				new Category
	//				{
	//					Id = Guid.Parse("41c1d6bf-035b-490d-a5a5-80990a61ac32"),
	//					Name = "Beauty & Health",
	//					Slug = "beauty-and-health",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511179514.png",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				},
	//				new Category
	//				{
	//					Id = Guid.Parse("716b7818-280f-4c6d-b221-010b314d6929"),
	//					Name = "Mobiles",
	//					Slug = "mobiles",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511156008.png",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				},
	//				new Category
	//				{
	//					Id = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"),
	//					Name = "Electronics",
	//					Slug = "electronics",
	//					ImageUrl = "https://ecommerce.routemisr.com/Route-Academy-categories/1681511121316.png",
	//					CreatedAt = DateTime.UtcNow,
	//					UpdatedAt = DateTime.UtcNow
	//				}
	//			);

	//			modelBuilder.Entity<SubCategory>().HasData(
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Diapers & Diaper Bags",
	//	Slug = "diapers-and-diaper-bags",
	//	CategoryId = Guid.Parse("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), // Baby & Toys
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Baby Safety Products",
	//	Slug = "baby-safety-products",
	//	CategoryId = Guid.Parse("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), // Baby & Toys
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Pet Supplies",
	//	Slug = "pet-supplies",
	//	CategoryId = Guid.Parse("451bbac9-4ae4-4c3d-a957-5c855af41d26"), // Pet Supplies
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Candy & Chocolate",
	//	Slug = "candy-and-chocolate",
	//	CategoryId = Guid.Parse("451bbac9-4ae4-4c3d-a957-5c855af41d26"), // Food & Snacks
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Baby Food",
	//	Slug = "baby-food",
	//	CategoryId = Guid.Parse("451bbac9-4ae4-4c3d-a957-5c855af41d26"), // Food & Snacks
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Breakfast Food",
	//	Slug = "breakfast-food",
	//	CategoryId = Guid.Parse("451bbac9-4ae4-4c3d-a957-5c855af41d26"), // Food & Snacks
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Snack Food",
	//	Slug = "snack-food",
	//	CategoryId = Guid.Parse("451bbac9-4ae4-4c3d-a957-5c855af41d26"), // Food & Snacks
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Home Care & Cleaning",
	//	Slug = "home-care-and-cleaning",
	//	CategoryId = Guid.Parse("451bbac9-4ae4-4c3d-a957-5c855af41d26"), // Home & Cleaning
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Beverages",
	//	Slug = "beverages",
	//	CategoryId = Guid.Parse("451bbac9-4ae4-4c3d-a957-5c855af41d26"), // Beverages
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Canned Dry and Packaged Foods",
	//	Slug = "canned-dry-and-packaged-foods",
	//	CategoryId = Guid.Parse("451bbac9-4ae4-4c3d-a957-5c855af41d26"), // Food & Snacks
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//}, new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Skin Care",
	//	Slug = "skin-care",
	//	CategoryId = Guid.Parse("41c1d6bf-035b-490d-a5a5-80990a61ac32"), // Beauty & Health
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Hair Care",
	//	Slug = "hair-care",
	//	CategoryId = Guid.Parse("41c1d6bf-035b-490d-a5a5-80990a61ac32"), // Beauty & Health
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Makeup",
	//	Slug = "makeup",
	//	CategoryId = Guid.Parse("41c1d6bf-035b-490d-a5a5-80990a61ac32"), // Beauty & Health
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Fragrance",
	//	Slug = "fragrance",
	//	CategoryId = Guid.Parse("41c1d6bf-035b-490d-a5a5-80990a61ac32"), // Beauty & Health
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Toys",
	//	Slug = "toys",
	//	CategoryId = Guid.Parse("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), // Baby & Toys
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Potty Training",
	//	Slug = "potty-training",
	//	CategoryId = Guid.Parse("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), // Baby & Toys
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Bouncers & Swings",
	//	Slug = "bouncers-and-swings",
	//	CategoryId = Guid.Parse("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), // Baby & Toys
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Car Seats & Strollers",
	//	Slug = "car-seats-and-strollers",
	//	CategoryId = Guid.Parse("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), // Baby & Toys
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Nursing & Feeding",
	//	Slug = "nursing-and-feeding",
	//	CategoryId = Guid.Parse("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), // Baby & Toys
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Bathing & Skin Care",
	//	Slug = "bathing-and-skin-care",
	//	CategoryId = Guid.Parse("bbb1a413-c3b4-455f-abb2-0cddf59cf2dd"), // Baby & Toys
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//}, new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Computer Accessories",
	//	Slug = "computer-accessories",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Computer Components",
	//	Slug = "computer-components",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Data Storage",
	//	Slug = "data-storage",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Networking Products",
	//	Slug = "networking-products",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Printers & Accessories",
	//	Slug = "printers-and-accessories",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Cameras & Accessories",
	//	Slug = "cameras-and-accessories",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Video Games",
	//	Slug = "video-games",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Audio & Home Entertainment",
	//	Slug = "audio-and-home-entertainment",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "Laptops & Accessories",
	//	Slug = "laptops-and-accessories",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//},
	//new SubCategory
	//{
	//	Id = Guid.NewGuid(),
	//	Name = "TVs, Satellites & Accessories",
	//	Slug = "tvs-satellites-and-accessories",
	//	CategoryId = Guid.Parse("9e89c85a-3d53-4dc0-b76f-8ca8f070caba"), // Electronics
	//	CreatedAt = DateTime.UtcNow,
	//	UpdatedAt = DateTime.UtcNow
	//}
	//);
	//		}



}
