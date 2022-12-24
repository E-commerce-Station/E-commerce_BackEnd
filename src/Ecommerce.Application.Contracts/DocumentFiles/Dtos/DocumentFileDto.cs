using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.DocumentFiles.Dtos
{
    [Serializable]
    public class DocumentFileDto : FullAuditedEntityDto<Guid>
    {
    }
}
