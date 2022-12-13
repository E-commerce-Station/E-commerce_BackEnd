using Ecommerce.OrderDetails.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.OrderDetails
{
    public interface IOrderDetailAppService : ICrudAppService<OrderDetailDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderDetailDto>
    {
    }
}
