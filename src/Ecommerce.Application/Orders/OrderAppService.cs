using Ecommerce.Orders.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Orders
{
    public class OrderAppService : CrudAppService<Order, OrderDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderDto>, IOrderAppService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderAppService(IOrderRepository orderRepository) : base(orderRepository)
        {
            _orderRepository = orderRepository;
        }
    }
}
