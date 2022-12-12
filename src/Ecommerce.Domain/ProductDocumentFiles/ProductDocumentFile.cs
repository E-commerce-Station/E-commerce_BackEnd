using Ecommerce.DocumentFiles;
using Ecommerce.Products;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.ProductDocumentFiles
{
    public class ProductDocumentFile : FullAuditedAggregateRoot<Guid>
    {
        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public ICollection<DocumentFile> DocumentFiles { get; set; }

        public ProductDocumentFile()
        {
            DocumentFiles = new HashSet<DocumentFile>();
        }
    }
}
