using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.DTO
{
	public class UpdateUserDataDto
	{
		[StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 50 characters")]
		public string? Name { get; set; }

		[EmailAddress(ErrorMessage = "Invalid email format")]
		public string? Email { get; set; }

		[RegularExpression(@"^01[0-2,5]\d{8}$", ErrorMessage = "Phone number must be a valid Egyptian number (e.g., 01012345678)")]
		public string? PhoneNumber { get; set; }
	}
}
