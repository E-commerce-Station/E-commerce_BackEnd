using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.Orders
{
    public interface IOrderRepository : IRepository<Order, Guid>
    {
        Task<IQueryable<Order>> GetListAsync();
    }
}
