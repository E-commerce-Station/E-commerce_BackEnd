using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Orders.Dtos
{
    [Serializable]
    public class OrderDto : FullAuditedEntityDto<Guid>
    {
    }
}
