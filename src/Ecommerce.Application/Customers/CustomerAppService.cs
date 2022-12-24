﻿using Ecommerce.Customers.Dtos;
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
    }
}