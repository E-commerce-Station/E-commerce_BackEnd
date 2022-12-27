using System;

namespace Ecommerce.ProductCategories.Dtos
{
    [Serializable]
    public class CreateUpdateProductCategoryDto
    {
        public Guid CategoryId { get; set; }
    }
}
