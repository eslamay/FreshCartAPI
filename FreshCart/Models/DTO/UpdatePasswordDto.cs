using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.DTO
{
	public class UpdatePasswordDto
	{
		[Required(ErrorMessage = "Current password is required")]
		public string CurrentPassword { get; set; }

		[Required(ErrorMessage = "New password is required")]
		[StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one number")]
		public string NewPassword { get; set; }
	}
}
