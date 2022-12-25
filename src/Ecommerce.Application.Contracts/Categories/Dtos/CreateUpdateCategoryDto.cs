using System;

namespace Ecommerce.Categories.Dtos
{
    [Serializable]
    public class CreateUpdateCategoryDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string Thumbnail { get; set; }
    }
}
