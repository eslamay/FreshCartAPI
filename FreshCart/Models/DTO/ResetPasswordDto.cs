using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.DTO
{
	public class ResetPasswordDto
	{
		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid email format")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Reset code is required")]
		public string ResetCode { get; set; }

		[Required(ErrorMessage = "New password is required")]
		[StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one number")]
		public string NewPassword { get; set; }
	}
}
