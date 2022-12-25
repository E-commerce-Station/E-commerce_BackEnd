using Ecommerce.Permissions;
using Ecommerce.Products.Dtos;
using System;
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
    }
}
