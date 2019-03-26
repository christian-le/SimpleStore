using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleStore.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private ICartLineRepository _cartLineRepository;

        public OrderService(IOrderRepository orderRepository, ICartLineRepository cartLineRepository)
        {
            _orderRepository = orderRepository;
            _cartLineRepository = cartLineRepository;
        }

        public async Task<List<Order>> GetAll()
        {
            return await _orderRepository.ListAllAsync();
        }

        public async Task SaveOrder(Order order)
        {
            if(order.Id == 0)
            {
                var orderEntity = await _orderRepository.AddAsync(order);

                //foreach(var item in order.Lines)
                //{
                    
                //    await _cartLineRepository.AddAsync(item);
                //}
            }
        }
    }
}
