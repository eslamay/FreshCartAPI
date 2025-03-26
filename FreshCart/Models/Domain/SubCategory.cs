using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.Domain
{
	public class SubCategory
	{
		[Key]
		public Guid Id { get; set; }

		[Required, MaxLength(100)]
		public string Name { get; set; }

		[Required, MaxLength(100)]
		public string Slug { get; set; }

		[ForeignKey("Category")]
		public Guid CategoryId { get; set; } // FK to Category
		public Category Category { get; set; }
		

		public DateTime CreatedAt { get; set; }
		public DateTime UpdatedAt { get; set; }
	}
}
