using AutoMapper;
using FreshCart.CustomActionFilters;
using FreshCart.Data;
using FreshCart.Models.Domain;
using FreshCart.Models.DTO;
using FreshCart.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FreshCart.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BrandsController : ControllerBase
	{
		private readonly IBrandRepository brandRepository;
		private readonly IMapper mapper;
		private readonly IHttpContextAccessor httpContextAccessor;

		public BrandsController(IBrandRepository brandRepository,IMapper mapper,IHttpContextAccessor httpContextAccessor)
		{
			this.brandRepository = brandRepository;
			this.mapper = mapper;
			this.httpContextAccessor = httpContextAccessor;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllBrands()
		{
			var BrandsDomainModel = await brandRepository.GetAllAsync();

		    var BrandDto=mapper.Map<List<BrandDto>>(BrandsDomainModel);

			return Ok(BrandDto);
		}

		[HttpGet]
		[Route("{id:guid}")]
		public async Task<IActionResult> GetBrandById(Guid id)
		{
			var BrandDomainModel= await brandRepository.GetByIdAsync(id);

			var BrandDto= mapper.Map<BrandDto>(BrandDomainModel);

			return Ok(BrandDto);
		}

		[HttpPost]
		[Authorize(Roles = "Admin")]
		[ValidateModel]
		public async Task<IActionResult> CreateBrand([FromForm]AddBrandDto addBrandDto)
		{
			string imageUrl = null;

			if (addBrandDto.Image != null && addBrandDto.Image.Length > 0)
			{
				var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "BrandImages");

				if (!Directory.Exists(uploadsFolder))
				{
					Directory.CreateDirectory(uploadsFolder);
				}

				var fileExtension = Path.GetExtension(addBrandDto.Image.FileName);
				var uniqueFileName = $"{addBrandDto.Name}{fileExtension}";
				var filePath = Path.Combine(uploadsFolder, uniqueFileName);

				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await addBrandDto.Image.CopyToAsync(stream);
				}

				imageUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/BrandImages/{uniqueFileName}";
			}

			var BrandDomainModel = mapper.Map<Brand>(addBrandDto);

			BrandDomainModel.Id = Guid.NewGuid();
			BrandDomainModel.CreatedAt = DateTime.UtcNow;
			BrandDomainModel.UpdatedAt = DateTime.UtcNow;
			BrandDomainModel.ImageUrl = imageUrl;

			await brandRepository.CreateAsync(BrandDomainModel);

			var BrandDto = mapper.Map<BrandDto>(BrandDomainModel);

            return CreatedAtAction(nameof(GetBrandById), new { id = BrandDto.Id }, BrandDto);

		}

		[HttpPut]
		[Route("{id:Guid}")]
		[Authorize(Roles = "Admin")]
		[ValidateModel]
		public async Task<IActionResult> UpdateBrand(Guid id, [FromForm]UpdateBrandDto updateBrandDto)
		{
			var BrandDomainModel=mapper.Map<Brand>(updateBrandDto);

			if (updateBrandDto.Image != null)
			{
				var fileExtension = Path.GetExtension(updateBrandDto.Image.FileName);
				var fileName = $"{updateBrandDto.Name}{fileExtension}";
				var filePath = Path.Combine("wwwroot/BrandImages", fileName);

				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await updateBrandDto.Image.CopyToAsync(stream);
				}

				BrandDomainModel.ImageUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/BrandImages/{fileName}";
			}

			BrandDomainModel.Name = updateBrandDto.Name;
			BrandDomainModel.Slug= updateBrandDto.Slug;
			BrandDomainModel.UpdatedAt = DateTime.UtcNow;

			BrandDomainModel= await brandRepository.UpdateAsync(id, BrandDomainModel);

			if (BrandDomainModel == null)
			{
				return NotFound();
			}

			var BrandDto=mapper.Map<BrandDto>(BrandDomainModel);

			return Ok(BrandDto);
		}

		[HttpDelete]
		[Authorize(Roles = "Admin")]
		[Route("{id:Guid}")]
		public async Task<IActionResult> DeleteBrand([FromRoute] Guid id)
		{
			var brandDomainModel = await brandRepository.DeleteAsync(id);

			if (brandDomainModel == null)
			{
				return NotFound();
			};

			var brandDto = mapper.Map<BrandDto>(brandDomainModel);

			return Ok(brandDto);

		}
	}
}
