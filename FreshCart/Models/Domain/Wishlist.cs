using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.Domain
{
	public class Wishlist
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[ForeignKey("User")]
		public string UserId { get; set; }
		public IdentityUser User { get; set; }

		[Required]
		[ForeignKey("Product")]
		public Guid ProductId { get; set; }
		public Product Product { get; set; }

		public DateTime AddedAt { get; set; }
	}
}
