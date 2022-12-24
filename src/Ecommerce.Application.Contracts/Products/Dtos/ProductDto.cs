using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Products.Dtos
{
    [Serializable]
    public class ProductDto : FullAuditedEntityDto<Guid>
    {
    }
}
