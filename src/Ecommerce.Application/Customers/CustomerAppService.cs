using Ecommerce.Customers.Dtos;
using System;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<bool> CheckLogin (string username, string password)
        {
            var user = (await _customerRepository.GetQueryableAsync()).FirstOrDefault(x => x.Name == username && x.Password == password);
            if(user == null)
            {
                return false;
            }
            return true;
        }
        public async Task<bool> UpdateUser (string name, string password, string email, string address, string country, string phone, string  cccd){
            var user = (await _customerRepository.GetQueryableAsync()).FirstOrDefault(x =>x.Name == name && x.Password == password && x.Email == email && x.Address == address && x.Country == country && x.Phone==phone && x.CCCD==cccd);
            if(user == null){
                return  false;
            }
            return true;
        }
    }
}
