namespace FreshCart.Models.DTO
{
	public class OrderDto
	{
		public Guid Id { get; set; }
		public decimal TotalPrice { get; set; }
		public string ShippingDetails { get; set; }
		public string ShippingPhone { get; set; }
		public string ShippingCity { get; set; }
		public bool IsPaid { get; set; }
		public string PaymentMethod { get; set; }
		public string Status { get; set; }
		public List<OrderItemDto> Items { get; set; }
		public DateTime CreatedAt { get; set; }
	}
}
