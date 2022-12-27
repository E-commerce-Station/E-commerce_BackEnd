using System;

namespace Ecommerce.ProductDocumentFiles.Dtos
{
    [Serializable]
    public class CreateUpdateProductDocumentFileDto
    {
        public Guid ProductId { get; set; }
    }
}
