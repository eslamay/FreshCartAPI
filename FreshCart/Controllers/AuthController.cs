using FreshCart.CustomActionFilters;
using FreshCart.Models.DTO;
using FreshCart.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FreshCart.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ITokenRepository _tokenRepository;

		public AuthController(
			UserManager<IdentityUser> userManager,
			RoleManager<IdentityRole> roleManager,
			ITokenRepository tokenRepository)
		{
			_userManager = userManager;
			_roleManager = roleManager;
			_tokenRepository = tokenRepository;
		}

		[HttpPost("register")]
		[ValidateModel]
		public async Task<IActionResult> Register([FromBody] RegisterRequestDto request)
		{

			// check password
			if (request.Password != request.RePassword)
			{
				return BadRequest(new { Message = "Passwords do not match" });
			}

			// check unique email 
			var existingUserByEmail = await _userManager.FindByEmailAsync(request.Email);
			if (existingUserByEmail != null)
			{
				return BadRequest(new { Message = "Email is already in use" });
			}

			// check phone
			var existingUserByPhone = await _userManager.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber);
			if (existingUserByPhone != null)
			{
				return BadRequest(new { Message = "Phone number is already in use" });
			}

			// create user
			var user = new IdentityUser
			{
				UserName = request.Name,
				Email = request.Email,
				PhoneNumber = request.PhoneNumber
			};

			var result = await _userManager.CreateAsync(user, request.Password);

			if (result.Succeeded)
			{
				//انشاء دور مستخم 
				if (await _roleManager.RoleExistsAsync("User"))
				{
					await _userManager.AddToRoleAsync(user, "User");
				}
				return Ok(new { Message = "User registered successfully" });
			}

			return BadRequest(new { Errors = result.Errors });
		}

		[HttpPost("login")]
		[ValidateModel]
		public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
		{

			var user = await _userManager.FindByEmailAsync(request.Email);
			if (user == null || !await _userManager.CheckPasswordAsync(user, request.Password))
			{
				return Unauthorized(new { Message = "Invalid email or password" });
			}


			var roles = await _userManager.GetRolesAsync(user);

			var token = _tokenRepository.CreateJWTToken(user, roles.ToList());

			return Ok(new { Token = token });
		}

		[HttpPost("forgot-password")]
		[ValidateModel]
		public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDto request)
		{
			var user = await _userManager.FindByEmailAsync(request.Email);
			if (user == null)
			{
				return BadRequest(new { Message = "Email not found" });
			}

			//  (Reset Code)
			var resetCode = await _userManager.GeneratePasswordResetTokenAsync(user);


			//  await _emailService.SendEmailAsync(user.Email, "Reset Password", $"Your reset code is: {resetCode}");

			return Ok(new { Message = "Reset code generated. Check your email.", ResetCode = resetCode }); // ResetCode for test
		}

		[HttpPost("verify-reset-code")]
		[ValidateModel]
		public async Task<IActionResult> VerifyResetCode([FromBody] VerifyResetCodeDto request)
		{

			var user = await _userManager.FindByEmailAsync(request.Email);
			if (user == null)
			{
				return BadRequest(new { Message = "Email not found" });
			}

			var isValidCode = await _userManager.VerifyUserTokenAsync(user, _userManager.Options.Tokens.PasswordResetTokenProvider, "ResetPassword", request.ResetCode);
			if (!isValidCode)
			{
				return BadRequest(new { Message = "Invalid or expired reset code" });
			}

			return Ok(new { Message = "Reset code verified successfully" });
		}

		[HttpPut("reset-password")]
		[ValidateModel]
		public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto request)
		{

			var user = await _userManager.FindByEmailAsync(request.Email);
			if (user == null)
			{
				return BadRequest(new { Message = "Email not found" });
			}

			var result = await _userManager.ResetPasswordAsync(user, request.ResetCode, request.NewPassword);
			if (result.Succeeded)
			{
				return Ok(new { Message = "Password reset successfully" });
			}

			return BadRequest(new { Errors = result.Errors });
		}

		[HttpPut("update-password")]
		[ValidateModel]
		public async Task<IActionResult> UpdateLoggedUserPassword([FromBody] UpdatePasswordDto request)
		{

			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			var user = await _userManager.FindByIdAsync(userId);
			if (user == null)
			{
				return Unauthorized(new { Message = "User not found" });
			}

			var result = await _userManager.ChangePasswordAsync(user, request.CurrentPassword, request.NewPassword);
			if (result.Succeeded)
			{
				return Ok(new { Message = "Password updated successfully" });
			}

			return BadRequest(new { Errors = result.Errors });
		}

		[Authorize]
		[HttpPut("update-user-data")]
		[ValidateModel]
		public async Task<IActionResult> UpdateLoggedUserData([FromBody] UpdateUserDataDto request)
		{


			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			var user = await _userManager.FindByIdAsync(userId);
			if (user == null)
			{
				return Unauthorized(new { Message = "User not found" });
			}
			//check and update email
			if (!string.IsNullOrEmpty(request.Email) && request.Email != user.Email)
			{
				var existingUserByEmail = await _userManager.FindByEmailAsync(request.Email);
				if (existingUserByEmail != null && existingUserByEmail.Id != user.Id)
				{
					return BadRequest(new { Message = "Email is already in use by another user" });
				}
				user.Email = request.Email;
				user.NormalizedEmail = _userManager.NormalizeEmail(request.Email);
			}

			// check and update phone number
			if (!string.IsNullOrEmpty(request.PhoneNumber) && request.PhoneNumber != user.PhoneNumber)
			{
				var existingUserByPhone = await _userManager.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber && u.Id != user.Id);
				if (existingUserByPhone != null)
				{
					return BadRequest(new { Message = "Phone number is already in use by another user" });
				}
				user.PhoneNumber = request.PhoneNumber;
			}

			// update name
			if (!string.IsNullOrEmpty(request.Name))
			{
				user.UserName = request.Name;
				user.NormalizedUserName = _userManager.NormalizeName(request.Name);
			}

			var result = await _userManager.UpdateAsync(user);
			if (result.Succeeded)
			{
				return Ok(new { Message = "User data updated successfully" });
			}


			return BadRequest(new { Errors = result.Errors });
		}

		[Authorize(Roles = "Admin")]
		[HttpGet("users")]
		public async Task<IActionResult> GetAllUsers()
		{
			var users = await _userManager.Users.ToListAsync();
			var userDtos = users.Select(u => new
			{
				u.Id,
				u.UserName,
				u.Email,
				u.PhoneNumber,
				Roles = _userManager.GetRolesAsync(u).Result
			});

			return Ok(userDtos);
		}

		[Authorize]
		[HttpGet("verify-token")]
		public IActionResult VerifyToken()
		{
			var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			var email = User.FindFirst(ClaimTypes.Email)?.Value;
			var roles = User.FindAll(ClaimTypes.Role).Select(r => r.Value).ToList();

			return Ok(new
			{
				UserId = userId,
				Email = email,
				Roles = roles,
				Message = "Token is valid"
			});
		}
	}
}