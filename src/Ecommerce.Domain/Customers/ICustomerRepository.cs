using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.Customers
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {
    }
}
