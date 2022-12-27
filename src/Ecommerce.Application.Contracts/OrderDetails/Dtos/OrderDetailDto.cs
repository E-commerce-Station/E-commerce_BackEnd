using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.OrderDetails.Dtos
{
    [Serializable]
    public class OrderDetailDto : FullAuditedEntityDto<Guid>
    {
        public Guid OrderId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public Guid ProductId { get; set; }
    }
}