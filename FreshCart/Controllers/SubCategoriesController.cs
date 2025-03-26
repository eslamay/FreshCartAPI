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
	public class SubCategoriesController : ControllerBase
	{
		private readonly IMapper mapper;
		private readonly ISubCategoryRepository subCategoryRepository;

		public SubCategoriesController(IMapper mapper,ISubCategoryRepository subCategoryRepository)
		{
			this.mapper = mapper;
			this.subCategoryRepository = subCategoryRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GellAllSubCategories()
		{
			var SubCategoryDomianModel = await subCategoryRepository.GetAllAsync();

			var SubCategoryDto=mapper.Map<List<SubCategoryDto>>(SubCategoryDomianModel);

			return Ok(SubCategoryDto);
		}

		[HttpGet]
		[Route("{id:Guid}")]
		public async Task<IActionResult> GetSubCategoryById(Guid id)
		{
			var SubCategoryDomianModel = await subCategoryRepository.GetByIdAsync(id);

			var SubCategoryDto = mapper.Map<SubCategoryDto>(SubCategoryDomianModel);

			return Ok(SubCategoryDto);
		}

		
		[HttpGet("category/{categoryId:Guid}")]
		public async Task<IActionResult> GetAllSubCategoriesByCategory(Guid categoryId)
		{

			var subCategories = await subCategoryRepository.GetAllByCategoryIdAsync(categoryId);

			if (subCategories==null)
			{
				return NotFound("Category ID InValid");
			}

			var subCategoryDtos = mapper.Map<List<SubCategoryDto>>(subCategories);

			return Ok(subCategoryDtos);
		}

		[HttpPost]
		[Authorize(Roles = "Admin")]
		[ValidateModel]
		public async Task<IActionResult> CreateSubCategory([FromBody] AddSubCategoryDto addSubCategoryDto)
		{
			var categoryExists = await subCategoryRepository.ExistsAsync(addSubCategoryDto.CategoryId);
			if (!categoryExists)
				return BadRequest("CategoryId Not Exists");

			var subCategory = mapper.Map<SubCategory>(addSubCategoryDto);
			subCategory.Id=Guid.NewGuid();
			subCategory.CreatedAt = DateTime.UtcNow;
			subCategory.UpdatedAt = DateTime.UtcNow;
			
			await subCategoryRepository.CreateAsync(subCategory);

			var subCategoryDto = mapper.Map<SubCategoryDto>(subCategory);
		
			return CreatedAtAction(nameof(GetSubCategoryById), new { id = subCategoryDto.Id }, subCategoryDto);
		}

		[HttpPut("{id:Guid}")]
		[Authorize(Roles = "Admin")]
		[ValidateModel]
		public async Task<IActionResult> UpdateSubCategory(Guid id, [FromBody] UpdateSubCategoryDto updateSubCategoryDto)
		{
			var subCategory = await subCategoryRepository.GetByIdAsync(id);
			if (subCategory == null)
				return NotFound();

			var categoryExists = await subCategoryRepository.ExistsAsync(updateSubCategoryDto.CategoryId);
			if (!categoryExists)
				return BadRequest("Invalid Category ID");

			mapper.Map(updateSubCategoryDto, subCategory);
			subCategory.UpdatedAt = DateTime.UtcNow;

			var updatedSubCategory = await subCategoryRepository.UpdateAsync(id, subCategory);
			if (updatedSubCategory == null)
				return StatusCode(500, "Error updating SubCategory");

			var subCategoryDto = mapper.Map<SubCategoryDto>(updatedSubCategory);
			return Ok(subCategoryDto);
		}


		[HttpDelete("{id:Guid}")]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> DeleteSubCategory(Guid id)
		{
			var subCategory = await subCategoryRepository.DeleteAsync(id);
			if (subCategory == null) return NotFound();


			var subCategoryDto = mapper.Map<SubCategoryDto>(subCategory);
			return Ok(subCategoryDto);
		}

	}
}
