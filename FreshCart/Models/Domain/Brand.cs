using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.Domain
{
	public class Brand
	{
		[Key]
		public Guid Id { get; set; }

		[Required, MaxLength(100)]
		public string Name { get; set; }

		[Required, MaxLength(100)]
		public string Slug { get; set; }

		public string? ImageUrl { get; set; }

		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
