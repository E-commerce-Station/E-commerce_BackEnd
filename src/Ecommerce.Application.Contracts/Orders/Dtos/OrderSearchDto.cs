using System;

namespace Ecommerce.Orders.Dtos
{
    public class OrderSearchDto
    {
        public Guid CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public int SkipCount { get; set; }

        public int MaxResultCount { get; set; }

        public string Sorting { get; set; }
    }
}
