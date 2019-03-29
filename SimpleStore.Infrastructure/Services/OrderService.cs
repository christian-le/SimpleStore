using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace SimpleStore.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAll()
        {
            return _orderRepository.ListAll();
        }

        public void SaveOrder(Order order)
        {
            if(order.Id == 0)
            {
                _orderRepository.Add(order);
            }
        }
    }
}
