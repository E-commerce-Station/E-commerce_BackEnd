using Ecommerce.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.Categories
{
    public class CategoryRepository : EfCoreRepository<EcommerceDbContext, Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
