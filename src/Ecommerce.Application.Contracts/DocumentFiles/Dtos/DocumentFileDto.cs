using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.DocumentFiles.Dtos
{
    [Serializable]
    public class DocumentFileDto : FullAuditedEntityDto<Guid>
    {
        public string Url { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public float Size { get; set; }

        public string FullName { get; set; }

        public string FileType { get; set; }

        public int OrderIndex { get; set; }

        public Guid ProductDocumentFileId { get; set; }
    }
}
