namespace FreshCart.Models.DTO
{
	public class AddCartItemDto
	{
		public Guid ProductId { get; set; }
		public int Quantity { get; set; }
	}
}
