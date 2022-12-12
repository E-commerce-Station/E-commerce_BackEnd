using Ecommerce.Orders.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Orders
{
    public interface IOrderAppService : ICrudAppService<OrderDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderDto>
    {
    }
}
