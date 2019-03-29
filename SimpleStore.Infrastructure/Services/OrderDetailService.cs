using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace SimpleStore.Infrastructure.Services
{
    public class OrderDetailService : IOrderDetailService
    {
        private IOrderDetailRepository _orderDetailRepository;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        public void SaveOrderDetails(IEnumerable<OrderDetail> orderDetails)
        {
            _orderDetailRepository.AddRange(orderDetails);
        }
    }
}
