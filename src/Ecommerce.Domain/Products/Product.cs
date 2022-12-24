using System;
using System.Collections.Generic;
using Ecommerce.OrderDetails;
using Ecommerce.ProductCategories;
using Ecommerce.ProductDocumentFiles;
using Ecommerce.ProductOptions;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Products
{
    public class Product : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public float Weight { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }

        public string Image { get; set; }

        public string Category { get; set; }

        public float Sale { get; set; }

        public ICollection<ProductOption> ProductOptions { get; set; }

        public Guid ProductCategoryId { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public ICollection<ProductDocumentFile> ProductDocumentFiles { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Product()
        {
            ProductOptions = new HashSet<ProductOption>();
            ProductDocumentFiles = new HashSet<ProductDocumentFile>();
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}
