using Ecommerce.Orders;
using Ecommerce.Products;
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.OrderDetails
{
    public class OrderDetail : FullAuditedAggregateRoot<Guid>
    {
        public Guid OrderId { get; set; }

        public Order Order { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }
    }
}
