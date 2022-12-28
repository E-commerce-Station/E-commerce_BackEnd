using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Products.Dtos
{
    [Serializable]
    public class ProductDto : FullAuditedEntityDto<Guid>
    {
        public Guid ProductId {get; set;}
         public string  Name {get; set;}
        public string  Description {get; set;}
        public string Thumbnail {get; set;}
        public string  Price {get; set;}
        public string  Weight {get; set;}
        public string  Image {get; set;}
        public string  Sale {get; set;}
            
    }
}
