using Ecommerce.ProductOptions.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.ProductOptions
{
    public class ProductOptionAppService : CrudAppService<ProductOption, ProductOptionDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductOptionDto>, IProductOptionAppService
    {
        private readonly IProductOptionRepository _productOptionRepository;

        public ProductOptionAppService(IProductOptionRepository productOptionRepository) : base(productOptionRepository)
        {
            _productOptionRepository = productOptionRepository;
        }
    }
}
