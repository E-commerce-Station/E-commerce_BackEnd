using Ecommerce.Customers.Dtos;
using Ecommerce.OrderDetails.Dtos;
using System;
using System.Collections.Generic;

namespace Ecommerce.Orders.Dtos
{
    [Serializable]
    public class CreateUpdateOrderDto
    {
        public int Ammount { get; set; }

        public string ShippingAddress { get; set; }

        public string OrderAddress { get; set; }

        public string OrderEmail { get; set; }

        public DateTime OrderDate { get; set; }

        public string Status { get; set; }

        public Guid CustomerId { get; set; }
    }
}
