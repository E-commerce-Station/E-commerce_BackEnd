using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Orders.Dtos
{
    [Serializable]
    public class OrderDto : FullAuditedEntityDto<Guid>
    {
        public string CustomerName { get; set; }

        public string ShippingAddress { get; set; }

        public DateTime OrderDate { get; set; }

        public int Ammount { get; set; }

        public string Status { get; set; }
    }
}
