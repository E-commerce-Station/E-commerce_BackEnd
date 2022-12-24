using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.Examples;

public interface IExampleRepository : IRepository<Example, Guid>
{
}