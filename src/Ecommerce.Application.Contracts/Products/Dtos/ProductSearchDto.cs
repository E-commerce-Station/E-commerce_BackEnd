using System;

namespace Ecommerce.Products.Dtos
{
    public class ProductSearchDto
    {      
        public Guid CategoryId { get; set; }

        public Guid OptionId {get; set;}

        public string Filter { get; set; }

        public int SkipCount { get; set; }

        public int MaxResultCount { get; set; }

        public string Sorting { get; set; }
    }
}