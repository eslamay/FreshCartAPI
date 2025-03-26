namespace FreshCart.Models.DTO
{
	public class CheckoutResponseDto
	{
		public string SessionId { get; set; } 
		public ShippingAddressResponseDto ShippingAddress { get; set; }
	}

	public class ShippingAddressResponseDto
	{
		public string Details { get; set; }
		public string Phone { get; set; }
		public string City { get; set; }
	}
}
