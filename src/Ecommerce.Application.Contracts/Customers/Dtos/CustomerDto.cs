using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Customers.Dtos
{
    [Serializable]
    public class CustomerDto : FullAuditedEntityDto<Guid>
    {
    }
}
