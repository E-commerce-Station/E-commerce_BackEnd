using System;

namespace Ecommerce.OrderDetails.Dtos
{
    [Serializable]
    public class CreateUpdateOrderDetailDto
    {
        public Guid OrderId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Guid ProductId { get; set; }
    }
}
