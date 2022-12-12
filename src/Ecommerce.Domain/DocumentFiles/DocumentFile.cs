using Ecommerce.ProductDocumentFiles;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.DocumentFiles
{
    public class DocumentFile : FullAuditedAggregateRoot<Guid>
    {
        public string Url { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public float Size { get; set; }

        public string FullName { get; set; }

        public string FileType { get; set; }
        
        public int OrderIndex { get; set; }

        public Guid ProductDocumentFileId { get; set; }

        public ProductDocumentFile ProductDocumentFile { get; set; }
    }
}
