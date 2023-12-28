using AutoMapper;
using Nlayer.Core.DTOs;
using Nlayer.Core.Model;

namespace Nlayer.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<ProductFeature, ProductFeatureDto>().ReverseMap();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();
            CreateMap<Category, CategoryWithProductsDto>();

            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<AppUserLoginDto, User>();

            CreateMap<UserRole, UserRoleDto>().ReverseMap();
        }
    }
}
