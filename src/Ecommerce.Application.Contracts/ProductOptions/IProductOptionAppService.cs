using Ecommerce.ProductOptions.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.ProductOptions
{
    public interface IProductOptionAppService : ICrudAppService<ProductOptionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductOptionDto>
    {
    }
}
