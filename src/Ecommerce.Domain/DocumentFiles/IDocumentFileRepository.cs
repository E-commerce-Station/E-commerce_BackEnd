using System;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.DocumentFiles
{
    public interface IDocumentFileRepository : IRepository<DocumentFile, Guid>
    {
    }
}
