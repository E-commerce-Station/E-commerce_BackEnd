using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.ProductDocumentFiles
{
    public interface IProductDocumentFileRepository : IRepository<ProductDocumentFile, Guid>
    {
    }
}
