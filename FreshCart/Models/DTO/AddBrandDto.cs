using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.DTO
{
	public class AddBrandDto
	{
		[Required, MaxLength(100)]
		public string Name { get; set; }

		[Required, MaxLength(100)]
		public string Slug { get; set; }

		public IFormFile? Image { get; set; }
	}
}
