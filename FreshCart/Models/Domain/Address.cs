using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FreshCart.Models.Domain
{
	public class Address
	{
		[Key]
		public Guid Id { get; set; }

		[Required]
		[ForeignKey("User")]
		public string UserId { get; set; }
		public IdentityUser User { get; set; }

		[Required, MaxLength(100)]
		public string Home { get; set; } 

		[Required, MaxLength(200)]
		public string Details { get; set; } 

		[Required, MaxLength(15)]
		public string Phone { get; set; } 

		[Required, MaxLength(100)]
		public string City { get; set; } 
	}
}
