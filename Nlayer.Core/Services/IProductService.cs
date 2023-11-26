using Nlayer.Core.DTOs;
using Nlayer.Core.Model;

namespace Nlayer.Core.Services
{
    public interface IProductService : IService<Product>
    {

        Task<List<ProductWithCategoryDto>> GetProductWithCategory();
    }
}
