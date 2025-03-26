using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.DTO
{
	using System.ComponentModel.DataAnnotations;

	public class RegisterRequestDto
	{
		[Required(ErrorMessage = "Name is required")]
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
		[DataType(DataType.Text)]
		public string Name { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid email format")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 100 characters")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, and one number")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Password confirmation is required")]
		[Compare("Password", ErrorMessage = "Passwords do not match")]
		[DataType(DataType.Password)]
		public string RePassword { get; set; }

		[Required(ErrorMessage = "Phone number is required")]
		[RegularExpression(@"^01[0-2,5]\d{8}$", ErrorMessage = "Phone number must be a valid Egyptian number (e.g., 01012345678)")]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }
	}
}
