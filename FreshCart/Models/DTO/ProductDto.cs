using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.DTO
{
	public class ProductDto
	{
		public Guid Id { get; set; }                                        

		[Required(ErrorMessage = "Title is required")]
		[MaxLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
		public string Title { get; set; } = string.Empty;                   

		[Required(ErrorMessage = "Slug is required")]
		[MaxLength(200, ErrorMessage = "Slug cannot exceed 200 characters")]
		public string Slug { get; set; } = string.Empty;                   

		public string? Description { get; set; }                            

		[Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
		public int Quantity { get; set; }                                   

		[Range(0, double.MaxValue, ErrorMessage = "Price cannot be negative")]
		public decimal Price { get; set; }                                  

		public string? ImageCoverUrl { get; set; }                          

		public List<string>? ImagesUrl { get; set; }                       

		[Range(0, int.MaxValue, ErrorMessage = "Sold cannot be negative")]
		public int Sold { get; set; }                                       

		[Range(0, 5, ErrorMessage = "Rating must be between 0 and 5")]
		public double RatingsAverage { get; set; }                          

		[Range(0, int.MaxValue, ErrorMessage = "Ratings quantity cannot be negative")]
		public int RatingsQuantity { get; set; }                            

		public DateTime CreatedAt { get; set; }                             
		public DateTime UpdatedAt { get; set; }                            

		public CategoryDto Category { get; set; } = null!;                 
		public SubCategoryDto SubCategory { get; set; } = null!;           
		public BrandDto Brand { get; set; } = null!;                       
	}
}
