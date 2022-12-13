using Ecommerce.ProductOptions;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Options
{
    public class Option : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<ProductOption> ProductOptions { get; set; }

        public Option()
        {
            ProductOptions = new HashSet<ProductOption>();
        }
    }
}
