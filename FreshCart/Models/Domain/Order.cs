using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.Domain
{
	public class Order
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[ForeignKey("User")]
		public string UserId { get; set; }
		public IdentityUser User { get; set; }

		public List<OrderItem> Items { get; set; } = new List<OrderItem>();

		[Required]
		public decimal TotalPrice { get; set; }

		[Required]
		public string ShippingDetails { get; set; }

		[Required]
		public string ShippingPhone { get; set; }

		[Required]
		public string ShippingCity { get; set; }

		[Required]
		public bool IsPaid { get; set; } = false;

		[Required]
		public string PaymentMethod { get; set; } // "Cash" أو "Online"

		[Required]
		public string Status { get; set; } = "Pending"; // "Pending", "Shipped", "Delivered", "Cancelled"

		public DateTime CreatedAt { get; set; } = DateTime.Now;
	}
}
