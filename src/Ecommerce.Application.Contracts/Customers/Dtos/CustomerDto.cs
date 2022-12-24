using System;
using Volo.Abp.Application.Dtos;

namespace Ecommerce.Customers.Dtos
{
    [Serializable]
    public class CustomerDto : FullAuditedEntityDto<Guid>
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
