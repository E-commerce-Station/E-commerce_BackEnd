using Ecommerce.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.Examples;

public class ExampleRepository : EfCoreRepository<EcommerceDbContext, Example, Guid>, IExampleRepository
{
    public ExampleRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Example>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}