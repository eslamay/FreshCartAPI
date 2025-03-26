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
	public class CategoriesController : ControllerBase
	{
		private readonly ICategoryRepository categoryRepository;
		private readonly IMapper mapper;
		private readonly IHttpContextAccessor httpContextAccessor;

		public CategoriesController(ICategoryRepository categoryRepository ,IMapper mapper, IHttpContextAccessor httpContextAccessor)
		{
			this.categoryRepository = categoryRepository;
			this.mapper = mapper;
			this.httpContextAccessor = httpContextAccessor;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllCategories()
		{
			var Categories = await categoryRepository.GetAllAsync();

			var categoryDto = mapper.Map<List<CategoryDto>>(Categories);

			return Ok(categoryDto);
		}

		[HttpGet]
		[Route("{id:Guid}")]
		public async Task<IActionResult> GetCategoriesById(Guid id)
		{
			var Categories = await categoryRepository.GetByIdAsync(id);

			var categoryDto = mapper.Map<CategoryDto>(Categories);

			return Ok(categoryDto);
		}

		[HttpPost]
		[Authorize(Roles = "Admin")]
		[ValidateModel]
		public async Task<IActionResult> CreateCategory([FromForm] AddCategoryDto addCategoryDto)
		{
			string imageUrl = null;

			if (addCategoryDto.Image != null && addCategoryDto.Image.Length > 0)
			{
				var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "CategoryImages");

				if (!Directory.Exists(uploadsFolder))
				{
					Directory.CreateDirectory(uploadsFolder);
				}

				var fileExtension = Path.GetExtension(addCategoryDto.Image.FileName);
				var uniqueFileName = $"{addCategoryDto.Name}{fileExtension}";
				var filePath = Path.Combine(uploadsFolder, uniqueFileName);

				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await addCategoryDto.Image.CopyToAsync(stream);
				}

				imageUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/CategoryImages/{uniqueFileName}";
			}

			var categoryDomainModel = mapper.Map<Category>(addCategoryDto);

			categoryDomainModel.Id = Guid.NewGuid();
			categoryDomainModel.CreatedAt = DateTime.UtcNow;
			categoryDomainModel.UpdatedAt = DateTime.UtcNow;
			categoryDomainModel.ImageUrl = imageUrl;

			categoryDomainModel=await categoryRepository.CreateAsync(categoryDomainModel);

			var categoryDto = mapper.Map<CategoryDto>(categoryDomainModel);

			return CreatedAtAction(nameof(GetCategoriesById), new { id = categoryDto.Id }, categoryDto);

		}

		[HttpPut]
		[Authorize(Roles = "Admin")]
		[Route("{id:Guid}")]
		[ValidateModel]
		public async Task<IActionResult> UpdateCategory([FromRoute] Guid id, [FromForm] UpdateCategoryDto updateCategoryDto)
		{
			var categoryDomainModel = mapper.Map<Category>(updateCategoryDto);


			if (updateCategoryDto.Image != null)
			{
				var fileExtension = Path.GetExtension(updateCategoryDto.Image.FileName);
				var fileName = $"{updateCategoryDto.Name}{fileExtension}";
				var filePath = Path.Combine("wwwroot/CategoryImages", fileName);

				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await updateCategoryDto.Image.CopyToAsync(stream);
				}

				categoryDomainModel.ImageUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/CategoryImages/{fileName}";
			}

			categoryDomainModel = await categoryRepository.UpdateAsync(id, categoryDomainModel);

			if (categoryDomainModel == null)
			{
				return NotFound();
			}

			var categoryDto = mapper.Map<CategoryDto>(categoryDomainModel);

			return Ok(categoryDto);

		}

		[HttpDelete]
		[Authorize(Roles = "Admin")]
		[Route("{id:Guid}")]
		public async Task<IActionResult> DeleteCategory([FromRoute] Guid id)
		{
			var categoryDomainModel = await categoryRepository.DeleteAsync(id);

			if (categoryDomainModel == null)
			{
				return NotFound();
			};

			var categoryDto = mapper.Map<CategoryDto>(categoryDomainModel);

			return Ok(categoryDto);

		}
	}
}
