using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.ProductCategories.Dtos
{
    [Serializable]
    public class ProductCategoryDto : FullAuditedEntityDto<Guid>
    {
    }
}
