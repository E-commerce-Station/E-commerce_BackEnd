using Ecommerce.ProductCategories;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Categories
{
    public class Category : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }

        public Category()
        {
            ProductCategories = new HashSet<ProductCategory>();
        }
    }
}
