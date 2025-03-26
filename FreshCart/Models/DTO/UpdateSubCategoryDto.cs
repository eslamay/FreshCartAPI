using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.DTO
{
	public class UpdateSubCategoryDto
	{
		[Required, MaxLength(100)]
		public string Name { get; set; }

		[Required, MaxLength(100)]
		public string Slug { get; set; }

		[Required]
		public Guid CategoryId { get; set; } 
	}

}
