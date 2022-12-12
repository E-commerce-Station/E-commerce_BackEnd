using Ecommerce.Options;
using Ecommerce.Products;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.ProductOptions
{
    public class ProductOption : FullAuditedAggregateRoot<Guid>
    {
        public Guid OptionId { get; set; }
        
        public Guid ProductId { get; set; }

        public Option Option { get; set; }

        public Product Product { get; set; }
    }
}
