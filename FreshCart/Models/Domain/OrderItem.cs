using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.Domain
{
	public class OrderItem
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[ForeignKey("Order")]
		public Guid OrderId { get; set; }
		public Order Order { get; set; }

		[Required]
		[ForeignKey("Product")]
		public Guid ProductId { get; set; }
		public Product Product { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		public decimal Price { get; set; } // سعر المنتج وقت الطلب
	}
}
