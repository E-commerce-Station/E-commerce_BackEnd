using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.Products
{
    public interface IProductRepository : IRepository<Product, Guid>
    {
    }
}
