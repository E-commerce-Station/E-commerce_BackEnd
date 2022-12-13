using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.Options
{
    public interface IOptionRepository : IRepository<Option, Guid>
    {
    }
}
