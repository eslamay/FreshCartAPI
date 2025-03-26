using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.Domain
{
	public class Product
	{
		[Key]
		public Guid Id { get; set; }

		[Required, MaxLength(200)]
		public string Title { get; set; }

		[Required, MaxLength(200)]
		public string Slug { get; set; }

		public string Description { get; set; }

		[Range(0, int.MaxValue)]
		public int Quantity { get; set; }

		[Range(0, double.MaxValue)]
		public decimal Price { get; set; }

		public string? ImageCoverUrl { get; set; }

		public List<string>? ImagesUrl { get; set; }

		[ForeignKey("Category")]
		public Guid CategoryId { get; set; }
		public Category Category { get; set; }

		[ForeignKey("SubCategory")]
		public Guid SubCategoryId { get; set; }
		public SubCategory SubCategory { get; set; } 

		[ForeignKey("Brand")]
		public Guid BrandId { get; set; }
		public Brand Brand { get; set; }

		[Range(0, int.MaxValue)]
		public int Sold { get; set; }

		[Range(0, 5)]
		public double RatingsAverage { get; set; }

		[Range(0, int.MaxValue)]
		public int RatingsQuantity { get; set; }

		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
