using Ecommerce.Customers;
using System;
using System.Collections.Generic;
using Ecommerce.OrderDetails;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Orders
{
    public class Order : FullAuditedAggregateRoot<Guid>
    {
        public int Ammount { get; set; }

        public string ShippingAddress { get; set; }
        
        public string OrderAddress { get; set; }

        public string OrderEmail { get; set; }

        public DateTime OrderDate { get; set; }

        public string Status { get; set; }

        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}
