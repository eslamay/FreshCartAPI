namespace FreshCart.Models.DTO
{
	public class CartDto
	{
		public Guid Id { get; set; }
		public List<CartItemDto> Items { get; set; }
		public decimal TotalCartPrice { get; set; } 
	}
}

