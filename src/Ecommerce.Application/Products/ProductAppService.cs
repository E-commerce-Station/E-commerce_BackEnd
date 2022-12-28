using Ecommerce.Permissions;
using Ecommerce.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Products
{
    public class ProductAppService : CrudAppService<Product, ProductDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateProductDto>, IProductAppService
    {
        protected override string GetPolicyName { get; set; } = EcommercePermissions.Product.Default;
        protected override string GetListPolicyName { get; set; } = EcommercePermissions.Product.Default;
        protected override string UpdatePolicyName { get; set; } = EcommercePermissions.Product.Update;
        protected override string DeletePolicyName { get; set; } = EcommercePermissions.Product.Delete;
        private readonly IProductRepository _productRepository;
        public ProductAppService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<PagedResultDto<ProductDto>> SearchAsync (ProductSearchDto condition)
        {
            PagedResultDto<ProductDto> listResultDto = new PagedResultDto<ProductDto>();
            var queryable = await _productRepository.GetQueryableAsync();
            var listProduct = queryable.Where(x => (string.IsNullOrEmpty(condition.Filter) && (condition.CategoryId == Guid.Empty || x.ProductCategory.CategoryId == condition.CategoryId)) 
            || (x.Name.Contains(condition.Filter) && (condition.CategoryId == Guid.Empty || x.ProductCategory.CategoryId == condition.CategoryId)));

            listResultDto.TotalCount = listProduct.Count();
            listProduct = listProduct.Skip(condition.SkipCount).Take(condition.MaxResultCount).OrderBy(condition.Sorting);
            listResultDto.Items = ObjectMapper.Map<List<Product>, List<ProductDto>>(listProduct.ToList());

            return listResultDto;
        }
        
    }
}
