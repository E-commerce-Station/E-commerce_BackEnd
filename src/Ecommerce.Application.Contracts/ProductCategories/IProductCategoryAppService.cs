using Ecommerce.ProductCategories.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.ProductCategories
{
    public interface IProductCategoryAppService : ICrudAppService<ProductCategoryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductCategoryDto>
    {
    }
}
