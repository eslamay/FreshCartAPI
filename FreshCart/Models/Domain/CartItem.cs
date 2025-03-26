using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.Domain
{
	public class CartItem
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[ForeignKey("Cart")]
		public Guid CartId { get; set; }
		public Cart Cart { get; set; }

		[Required]
		[ForeignKey("Product")]
		public Guid ProductId { get; set; }
		public Product Product { get; set; }

		[Required]
		[Range(1, int.MaxValue)]
		public int Quantity { get; set; }
	}
}
