using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Products.Dtos
{
    [Serializable]
    public class ProductDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public float Weight { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }

        public string Image { get; set; }

        public string Category { get; set; }

        public float Sale { get; set; }

        public Guid ProductCategoryId { get; set; }
    }
}
