using Ecommerce.Customers.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Customers
{
    public interface ICustomerAppService : ICrudAppService<CustomerDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateCustomerDto>
    {
        Task<CustomerDto> CheckLoginAsync(string email, string password);

        Task<PagedResultDto<CustomerDto>> SearchAsync(CustomerSearchDto condition);
    }
}
