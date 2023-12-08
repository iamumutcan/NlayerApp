using Nlayer.Core.DTOs;
using Nlayer.Core.Model;

namespace Nlayer.Core.Services
{
    public interface IProductService : IService<Product>
    {

        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductWithCategory();
    }
}
