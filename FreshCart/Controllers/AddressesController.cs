using AutoMapper;
using FreshCart.CustomActionFilters;
using FreshCart.Models.Domain;
using FreshCart.Models.DTO;
using FreshCart.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FreshCart.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddressesController : ControllerBase
	{
		private readonly IAddressRepository addressRepository;
		private readonly IMapper mapper;

		public AddressesController(IAddressRepository addressRepository, IMapper mapper)
		{
			this.addressRepository = addressRepository;
			this.mapper = mapper;
		}

		[HttpPost]
		[ValidateModel]
		public async Task<IActionResult> AddAddress([FromBody] AddAddressDto addAddressDto)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var address = mapper.Map<Address>(addAddressDto);
			var createdAddress = await addressRepository.AddAddressAsync(userId, address);
			var addressDto = mapper.Map<AddressDto>(createdAddress);

			return Ok(addressDto);
		}

		
		[HttpDelete]
		[Route("{addressId:Guid}")]
		public async Task<IActionResult> RemoveAddress(Guid addressId)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var removed = await addressRepository.RemoveAddressAsync(userId, addressId);
			if (!removed)
			{
				return NotFound("Address not found.");
			}

			return Ok(new { message = "Address removed successfully." });
		}

		
		[HttpGet]
		[Route("{addressId:Guid}")]
		public async Task<IActionResult> GetAddress(Guid addressId)
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var address = await addressRepository.GetAddressByIdAsync(userId, addressId);
			if (address == null)
			{
				return NotFound("Address not found.");
			}

			var addressDto = mapper.Map<AddressDto>(address);
			return Ok(addressDto);
		}

		
		[HttpGet]
		public async Task<IActionResult> GetUserAddresses()
		{
			var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
			if (string.IsNullOrEmpty(userId))
			{
				return Unauthorized("User not authenticated.");
			}

			var addresses = await addressRepository.GetUserAddressesAsync(userId);
			var addressDtos = mapper.Map<List<AddressDto>>(addresses);

			return Ok(addressDtos);
		}
	}
}
