using System;

namespace Ecommerce.Customers.Dtos
{
    [Serializable]
    public class CreateUpdateCustomerDto
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string CCCD { get; set; }
    }
}
