namespace FreshCart.Models.DTO
{
	public class OrderItemDto
	{
		public Guid Id { get; set; }
		public Guid ProductId { get; set; }
		public string ProductTitle { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public decimal TotalPrice { get; set; } // السعر الإجمالي للعنصر
	}
}
