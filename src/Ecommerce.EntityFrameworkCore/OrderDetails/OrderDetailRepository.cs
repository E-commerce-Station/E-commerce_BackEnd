using Ecommerce.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.OrderDetails
{
    public class OrderDetailRepository : EfCoreRepository<EcommerceDbContext, OrderDetail, Guid>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
