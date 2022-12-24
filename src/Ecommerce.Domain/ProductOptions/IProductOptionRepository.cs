using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.ProductOptions
{
    public interface IProductOptionRepository : IRepository<ProductOption, Guid>
    {
    }
}
