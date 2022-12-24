using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.Orders
{
    public interface IOrderRepository : IRepository<Order, Guid>
    {
    }
}
