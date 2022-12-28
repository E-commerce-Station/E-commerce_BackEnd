using Ecommerce.Orders.Dtos;
using Ecommerce.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Ecommerce.Orders
{
    public class OrderAppService : CrudAppService<Order, OrderDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateOrderDto>, IOrderAppService
    {
        protected override string GetPolicyName { get; set; } = EcommercePermissions.Order.Default;
        protected override string UpdatePolicyName { get; set; } = EcommercePermissions.Order.UpdateStatus;
        private readonly IOrderRepository _orderRepository;

        public OrderAppService(IOrderRepository orderRepository) : base(orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<PagedResultDto<OrderDto>> SearchAsync(OrderSearchDto condition)
        {
            PagedResultDto<OrderDto> listResultDto = new PagedResultDto<OrderDto>();
            condition.OrderDate = condition.OrderDate.Date;
            var queryable = await _orderRepository.GetListAsync();
            var listCustomer = queryable.Where(x => 
                (condition.CustomerId == Guid.Empty && x.OrderDate.Date == condition.OrderDate) || 
                (x.OrderDate.Date == condition.OrderDate && x.Customer.Id == condition.CustomerId));

            listResultDto.TotalCount = listCustomer.Count();
            listCustomer = listCustomer.Skip(condition.SkipCount).Take(condition.MaxResultCount).OrderBy(condition.Sorting);
            listResultDto.Items = ObjectMapper.Map<List<Order>, List<OrderDto>>(listCustomer.ToList());

            return listResultDto;
        }

       /* public override Task<OrderDto> CreateAsync(CreateUpdateOrderDto input)
        {
            input.Ammount = input.OrderDetailDtos.Select(x => x.Quantity).Sum();
            return base.CreateAsync(input);
        }*/
    }
}
