using Ecommerce.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.DocumentFiles
{
    public class DocumentFileRepository : EfCoreRepository<EcommerceDbContext, DocumentFile, Guid>, IDocumentFileRepository
    {
        public DocumentFileRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
