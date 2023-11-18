using Nlayer.Core.DTOs;
using Nlayer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Services
{
    public interface IProductService:IService<Product>
    {

        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductWithCategory();
    }
}
