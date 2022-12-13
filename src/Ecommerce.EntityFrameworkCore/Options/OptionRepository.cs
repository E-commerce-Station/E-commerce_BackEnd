using Ecommerce.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.Options
{
    public class OptionRepository : EfCoreRepository<EcommerceDbContext, Option, Guid>, IOptionRepository
    {
        public OptionRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
