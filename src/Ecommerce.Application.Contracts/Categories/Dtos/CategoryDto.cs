using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Categories.Dtos
{
    [Serializable]
    public class CategoryDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }
    }
}
