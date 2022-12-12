using Ecommerce.OrderDetails.Dtos;
using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.OrderDetails
{
    public class OrderDetailAppService : CrudAppService<OrderDetail, OrderDetailDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderDetailDto>, IOrderDetailAppService
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailAppService(IOrderDetailRepository orderDetailRepository) : base(orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
    }
}
