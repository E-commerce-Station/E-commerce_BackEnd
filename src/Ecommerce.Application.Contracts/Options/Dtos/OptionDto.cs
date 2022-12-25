using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Options.Dtos
{
    [Serializable]
    public class OptionDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
