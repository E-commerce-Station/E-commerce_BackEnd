using Ecommerce.Products.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Products
{
    public interface IProductAppService : ICrudAppService<ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>
    {
    }
}
