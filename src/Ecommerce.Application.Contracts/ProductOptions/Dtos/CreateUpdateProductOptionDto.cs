using System;

namespace Ecommerce.ProductOptions.Dtos
{
    [Serializable]
    public class CreateUpdateProductOptionDto
    {
        public Guid OptionId { get; set; }

        public Guid ProductId { get; set; }
    }
}
