using Ecommerce.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.ProductOptions
{
    public class ProductOptionRepository : EfCoreRepository<EcommerceDbContext, ProductOption, Guid>, IProductOptionRepository
    {
        public ProductOptionRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
