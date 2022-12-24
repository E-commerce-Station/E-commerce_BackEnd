using Ecommerce.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.ProductCategories
{
    public class ProductCategoryRepository : EfCoreRepository<EcommerceDbContext, ProductCategory, Guid>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
