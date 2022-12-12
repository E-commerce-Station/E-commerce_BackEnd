using Ecommerce.Orders;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace Ecommerce.Customers
{
    public class Customer : FullAuditedAggregateRoot<Guid>
    {
        public string Email { get; set; }

        public string Password { get; set; }
        
        public string Name { get; set; }

        public string Address { get; set; }
        
        public string Country { get; set; }

        public string Phone { get; set; }

        public string CCCD { get; set; }

        public ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new HashSet<Order>();
        }
    }
}
