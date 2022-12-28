using Ecommerce.Products.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Products
{
    public interface IProductAppService : ICrudAppService<ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>
    {
        // Task<ListResultDto<ProductDto>> CreateProduct (CreateUpdateProductDto condition);
        // Task<ListResultDto<ProductDto>> UpDateProduct (CreateUpdateProductDto condition);
        // Task<ListResultDto<ProductDto>> DeleteProduct (CreateUpdateProductDto condition);
    }
}
