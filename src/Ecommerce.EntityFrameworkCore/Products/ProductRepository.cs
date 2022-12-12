using Ecommerce.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.Products
{
    public class ProductRepository : EfCoreRepository<EcommerceDbContext, Product, Guid>, IProductRepository
    {
        public ProductRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
