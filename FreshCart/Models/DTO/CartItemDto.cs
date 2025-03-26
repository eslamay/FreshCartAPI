namespace FreshCart.Models.DTO
{
	public class CartItemDto
	{
		public Guid Id { get; set; }
		public Guid ProductId { get; set; }
		public string ProductTitle { get; set; }
		public decimal ProductPrice { get; set; }
		public string? ImageCoverUrl { get; set; }
		public int Quantity { get; set; }
		public decimal TotalPrice { get; set; } // السعر الإجمالي للعنصر (السعر * الكمية)
	}
}
