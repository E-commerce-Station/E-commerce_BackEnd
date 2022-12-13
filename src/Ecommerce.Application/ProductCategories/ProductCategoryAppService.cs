using Ecommerce.ProductCategories.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.ProductCategories
{
    public class ProductCategoryAppService : CrudAppService<ProductCategory, ProductCategoryDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductCategoryDto>, IProductCategoryAppService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryAppService(IProductCategoryRepository productCategoryRepository) : base(productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }
    }
}
