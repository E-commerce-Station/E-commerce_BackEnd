using Ecommerce.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.Orders
{
    public class OrderRepository : EfCoreRepository<EcommerceDbContext, Order, Guid>, IOrderRepository
    {
        public OrderRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<IQueryable<Order>> GetListAsync()
        {
            return (await GetQueryableAsync()).IncludeDetails();
        }
    }
}
