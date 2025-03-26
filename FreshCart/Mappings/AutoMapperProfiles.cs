
using AutoMapper;
using FreshCart.Models.Domain;
using FreshCart.Models.DTO;

namespace FreshCart.Mappings
{
	public class AutoMapperProfiles:Profile
	{
		public AutoMapperProfiles()
		{
			//category map
			CreateMap<Category, CategoryDto>();

			CreateMap<AddCategoryDto, Category>().ForMember(dest => dest.ImageUrl, opt => opt.Ignore());

			CreateMap<UpdateCategoryDto, Category>().ForMember(dest => dest.ImageUrl, opt => opt.Ignore());

			//subcategory map

			CreateMap<SubCategory, SubCategoryDto>();

			CreateMap<AddSubCategoryDto, SubCategory>();

			CreateMap<UpdateSubCategoryDto, SubCategory>();

			//Brand Map

			CreateMap<Brand, BrandDto>();

			CreateMap<AddBrandDto, Brand>().ForMember(dest => dest.ImageUrl, opt => opt.Ignore());

			CreateMap<UpdateBrandDto, Brand>().ForMember(dest => dest.ImageUrl, opt => opt.Ignore());

			//Product Map

			CreateMap<Product, ProductDto>();

			CreateMap<AddProductDto, Product>()
				.ForMember(dest => dest.Id, opt => opt.Ignore())           
				.ForMember(dest => dest.Sold, opt => opt.Ignore())         
				.ForMember(dest => dest.RatingsAverage, opt => opt.Ignore()) 
				.ForMember(dest => dest.RatingsQuantity, opt => opt.Ignore())
				.ForMember(dest => dest.CreatedAt, opt => opt.Ignore())     
				.ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())     
				.ForMember(dest => dest.ImageCoverUrl, opt => opt.Ignore()) 
				.ForMember(dest => dest.ImagesUrl, opt => opt.Ignore())     
				.ForMember(dest => dest.Category, opt => opt.Ignore())      
				.ForMember(dest => dest.SubCategory, opt => opt.Ignore())   
				.ForMember(dest => dest.Brand, opt => opt.Ignore());        

			CreateMap<UpdateProductDto, Product>()
				.ForMember(dest => dest.Id, opt => opt.Ignore())           
				.ForMember(dest => dest.Sold, opt => opt.Ignore())         
				.ForMember(dest => dest.RatingsAverage, opt => opt.Ignore()) 
				.ForMember(dest => dest.RatingsQuantity, opt => opt.Ignore()) 
				.ForMember(dest => dest.CreatedAt, opt => opt.Ignore())    
				.ForMember(dest => dest.UpdatedAt, opt => opt.Ignore())     
				.ForMember(dest => dest.ImageCoverUrl, opt => opt.Ignore()) 
				.ForMember(dest => dest.ImagesUrl, opt => opt.Ignore())    
				.ForMember(dest => dest.Category, opt => opt.Ignore())      
				.ForMember(dest => dest.SubCategory, opt => opt.Ignore())   
				.ForMember(dest => dest.Brand, opt => opt.Ignore());

			//map wishlist
			CreateMap<Wishlist, WishlistDto>()
				.ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.Product));

			// map Address
			CreateMap<Address, AddressDto>();
			CreateMap<AddAddressDto, Address>();

			//map Cart
			CreateMap<CartItem, CartItemDto>();

			//map order
			CreateMap<Order, OrderDto>();
			CreateMap<OrderItem, OrderItemDto>();
		}
	}
}
