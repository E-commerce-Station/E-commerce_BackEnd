using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.Categories
{
    public interface ICategoryRepository : IRepository<Category, Guid>
    {
    }
}
