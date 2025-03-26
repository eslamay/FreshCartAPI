using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.DTO
{
	public class VerifyResetCodeDto
	{
		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid email format")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Reset code is required")]
		public string ResetCode { get; set; }
	}
}
