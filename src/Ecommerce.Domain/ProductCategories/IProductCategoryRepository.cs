using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.ProductCategories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, Guid>
    {
    }
}
