namespace FreshCart.Models.DTO
{
	public class WishlistDto
	{
		public Guid Id { get; set; }
		public ProductDto Product { get; set; } 
		public DateTime AddedAt { get; set; }
	}
}
