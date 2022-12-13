using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.OrderDetails
{
    public interface IOrderDetailRepository : IRepository<OrderDetail, Guid>
    {
    }
}
