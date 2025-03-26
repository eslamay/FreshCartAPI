using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.Domain
{
	public class Cart
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[ForeignKey("User")]
		public string UserId { get; set; }
		public IdentityUser User { get; set; }

		public List<CartItem> Items { get; set; } = new List<CartItem>();
	}
}
