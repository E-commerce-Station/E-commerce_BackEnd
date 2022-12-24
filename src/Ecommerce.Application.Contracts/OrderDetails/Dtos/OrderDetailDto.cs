using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.OrderDetails.Dtos
{
    [Serializable]
    public class OrderDetailDto : FullAuditedEntityDto<Guid>
    {
    }
}
