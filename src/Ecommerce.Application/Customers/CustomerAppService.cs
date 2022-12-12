using Ecommerce.Customers.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Customers
{
    public class CustomerAppService : CrudAppService<Customer, CustomerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCustomerDto>, ICustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
