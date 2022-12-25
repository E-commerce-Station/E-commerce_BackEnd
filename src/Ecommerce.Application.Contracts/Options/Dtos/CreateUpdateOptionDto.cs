using System;

namespace Ecommerce.Options.Dtos
{
    [Serializable]
    public class CreateUpdateOptionDto
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
