using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.DTO
{
	public class AddProductDto
	{
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

		public IFormFile? ImageCover { get; set; }                          

		public IFormFile[]? Images { get; set; }                            

		public Guid CategoryId { get; set; }                               
		public Guid SubCategoryId { get; set; }                             
		public Guid BrandId { get; set; }                                   
	}
}
