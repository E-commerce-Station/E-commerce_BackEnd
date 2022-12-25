using Ecommerce.Customers.Dtos;
using Ecommerce.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Customers
{
    public class CustomerAppService : CrudAppService<Customer, CustomerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCustomerDto>, ICustomerAppService
    {
        protected override string GetPolicyName { get; set; } = EcommercePermissions.Customer.Default;
        private readonly ICustomerRepository _customerRepository;

        public CustomerAppService(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<CustomerDto> CheckLoginAsync (string userName, string password)
        {
            var user = (await _customerRepository.GetQueryableAsync()).FirstOrDefault(x => (x.Email == userName || x.Phone == userName) && x.Password == password);
            
            return ObjectMapper.Map<Customer, CustomerDto>(user);
        }

        public async Task<PagedResultDto<CustomerDto>> SearchAsync(CustomerSearchDto condition)
        {
            PagedResultDto<CustomerDto> listResultDto = new PagedResultDto<CustomerDto>();
            var queryable = await _customerRepository.GetQueryableAsync();
            var listCustomer = queryable.Where(x => string.IsNullOrEmpty(condition.Filter) || x.Email.Contains(condition.Filter) || x.Name.Contains(condition.Filter) || x.Phone.Contains(condition.Filter));

            listResultDto.TotalCount = listCustomer.Count();
            listCustomer = listCustomer.Skip(condition.SkipCount).Take(condition.MaxResultCount).OrderBy(condition.Sorting);
            listResultDto.Items = ObjectMapper.Map<List<Customer>, List<CustomerDto>>(listCustomer.ToList());

            return listResultDto;
        }
    }
}