using Ecommerce.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Customers
{
    public class CustomerRepository : EfCoreRepository<EcommerceDbContext, Customer, Guid>, ICustomerRepository
    {
        public CustomerRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
