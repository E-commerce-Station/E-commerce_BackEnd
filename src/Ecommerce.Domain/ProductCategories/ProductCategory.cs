using Ecommerce.Products;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;
using Ecommerce.Categories;

namespace Ecommerce.ProductCategories
{
    public class ProductCategory : FullAuditedAggregateRoot<Guid>
    {
        public Guid CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Product> Products { get; set; }

        public ProductCategory()
        {
            Products = new HashSet<Product>();
        }
    }
}
