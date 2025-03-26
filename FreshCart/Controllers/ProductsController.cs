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
using System.IO;

namespace FreshCart.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly ApplicationDbContext dbContext;
		private readonly IProductRepository productRepository;
		private readonly IMapper mapper;
		private readonly IHttpContextAccessor httpContextAccessor;

		public ProductsController(ApplicationDbContext dbContext,IProductRepository productRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
		{
			this.dbContext = dbContext;
			this.productRepository = productRepository;
			this.mapper = mapper;
			this.httpContextAccessor = httpContextAccessor;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllProducts([FromQuery] string? sortBy = null,
			                                            [FromQuery] string? categoryName = null,
			                                            [FromQuery] int pageNumber = 1,
			                                            [FromQuery] int pageSize = 20)
		{
			var products = await productRepository.GetAllAsync(sortBy,categoryName,pageNumber,pageSize);

			var totalCount=products.Count();

			var productDto = mapper.Map<List<ProductDto>>(products);

			
			int totalPages = (int)Math.Ceiling((double)totalCount / pageSize);
			
			int? nextPage = pageNumber < totalPages ? pageNumber + 1 : (int?)null;

			//response products
			var response = new
			{
				results=totalCount,
				metadata = new
				{
					currentPage = pageNumber,
					numberOfPages = totalPages,
					limit = pageSize,
					nextPage = nextPage
				},
				data = productDto
			};

			return Ok(response);
		}

		[HttpGet]
		[Route("{id:Guid}")]
		public async Task<IActionResult> GetProductById(Guid id)
		{
			var productDomainModel = await productRepository.GetByIdAsync(id);

			var productDto = mapper.Map<ProductDto>(productDomainModel);

			return Ok(productDto);
		}

		[HttpPost]
		[Authorize(Roles = "Admin")]
		[ValidateModel]
		public async Task<IActionResult> CreateProducte([FromForm] AddProductDto addProductDto)
		{
			var productDomainModel = mapper.Map<Product>(addProductDto);


			// Handle ImageCover upload
			string imageCoverUrl = null;
			if (addProductDto.ImageCover != null && addProductDto.ImageCover.Length > 0)
			{
				var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ProductImages");

				if (!Directory.Exists(uploadsFolder))
				{
					Directory.CreateDirectory(uploadsFolder);
				}

				var fileExtension = Path.GetExtension(addProductDto.ImageCover.FileName);
				var uniqueFileName = $"{addProductDto.Title}_cover{fileExtension}";
				var filePath = Path.Combine(uploadsFolder, uniqueFileName);

				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await addProductDto.ImageCover.CopyToAsync(stream);
				}

				imageCoverUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/ProductImages/{uniqueFileName}";
				productDomainModel.ImageCoverUrl = imageCoverUrl;
			}

			// Handle Images upload
			if (addProductDto.Images != null && addProductDto.Images.Length > 0)
			{
				var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ProductImages");

				if (!Directory.Exists(uploadsFolder))
				{
					Directory.CreateDirectory(uploadsFolder);
				}

				productDomainModel.ImagesUrl = new List<string>();
				int imageCounter = 1; // عشان نعمل ترقيم للصور
				foreach (var image in addProductDto.Images)
				{
					if (image != null && image.Length > 0)
					{
						var fileExtension = Path.GetExtension(image.FileName);
						var uniqueFileName = $"{addProductDto.Title}_image{imageCounter}{fileExtension}";
						var filePath = Path.Combine(uploadsFolder, uniqueFileName);

						using (var stream = new FileStream(filePath, FileMode.Create))
						{
							await image.CopyToAsync(stream);
						}

						var imageUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/ProductImages/{uniqueFileName}";
						productDomainModel.ImagesUrl.Add(imageUrl);
						imageCounter++;
					}
				}
			}

			await productRepository.CreateAsync(productDomainModel);

			var productDto = mapper.Map<ProductDto>(productDomainModel);

			return CreatedAtAction(nameof(GetProductById), new { id = productDto.Id }, productDto);
		}

		[HttpPut]
		[Authorize(Roles = "Admin")]
		[Route("{id:Guid}")]
		[ValidateModel]
		public async Task<IActionResult> UpdateProducts(Guid id, [FromForm] UpdateProductDto updateProductDto)
		{
			var ProductDomainModel = await productRepository.GetByIdAsync(id);

			if (ProductDomainModel == null)
			{
				return NotFound();
			}

			// Store old image URLs before updating
			var oldImageCoverUrl = ProductDomainModel.ImageCoverUrl;
			var oldImagesUrl = ProductDomainModel.ImagesUrl != null ? new List<string>(ProductDomainModel.ImagesUrl) : null;

			mapper.Map(updateProductDto, ProductDomainModel);


			// Handle ImageCover upload
			if (updateProductDto.ImageCover != null)
			{
				var fileExtension = Path.GetExtension(updateProductDto.ImageCover.FileName);
				var fileName = $"{updateProductDto.Title}{fileExtension}";
				var filePath = Path.Combine("wwwroot/ProductImages", fileName);

				using (var stream = new FileStream(filePath, FileMode.Create))
				{
					await updateProductDto.ImageCover.CopyToAsync(stream);
				}

				ProductDomainModel.ImageCoverUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/ProductImages/{fileName}";

				// Delete old ImageCover if it exists
				if (!string.IsNullOrEmpty(oldImageCoverUrl))
				{
					var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ProductImages", Path.GetFileName(oldImageCoverUrl.Split('/').Last()));
					if (System.IO.File.Exists(oldFilePath))
					{
						System.IO.File.Delete(oldFilePath);
					}
				}
			}

			// Handle Images upload
			if (updateProductDto.Images != null && updateProductDto.Images.Length > 0)
			{
				ProductDomainModel.ImagesUrl = new List<string>();
				int imageCounter = 1;
				foreach (var image in updateProductDto.Images)
				{
					if (image != null)
					{
						var fileExtension = Path.GetExtension(image.FileName);
						var fileName = $"{updateProductDto.Title}{imageCounter}{fileExtension}";
						var filePath = Path.Combine("wwwroot/ProductImages", fileName);

						using (var stream = new FileStream(filePath, FileMode.Create))
						{
							await image.CopyToAsync(stream);
						}

						var imageUrl = $"{httpContextAccessor.HttpContext.Request.Scheme}://{httpContextAccessor.HttpContext.Request.Host}{httpContextAccessor.HttpContext.Request.PathBase}/ProductImages/{fileName}";
						ProductDomainModel.ImagesUrl.Add(imageUrl);
						imageCounter++;
					}
				}
			}

			// Delete old Images if they exist
			if (oldImagesUrl != null)
			{
				foreach (var oldImageUrl in oldImagesUrl)
				{
					var oldFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "ProductImages", Path.GetFileName(oldImageUrl.Split('/').Last()));
					if (System.IO.File.Exists(oldFilePath)) 
					{
						System.IO.File.Delete(oldFilePath);
					}
				}
			}

			await productRepository.UpdateAsync(id,ProductDomainModel);

			var productDto = mapper.Map<ProductDto>(ProductDomainModel);

			return Ok(productDto);
		}

		[HttpDelete]
		[Authorize(Roles = "Admin")]
		[Route("{id:Guid}")]
		public async Task<IActionResult> DeleteProduct(Guid id)
		{
			var product = await productRepository.DeleteAsync(id);
			if (product == null)
			{
				return NotFound();
			}

			var productDto = mapper.Map<ProductDto>(product);
			return Ok(productDto);
		}
	
	}
}
