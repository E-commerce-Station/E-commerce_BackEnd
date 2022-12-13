using Ecommerce.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Ecommerce.ProductDocumentFiles
{
    public class ProductDocumentFileRepository : EfCoreRepository<EcommerceDbContext, ProductDocumentFile, Guid>, IProductDocumentFileRepository
    {
        public ProductDocumentFileRepository(IDbContextProvider<EcommerceDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
