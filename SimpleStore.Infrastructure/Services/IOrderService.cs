using SimpleStore.Infrastructure.Entities;
using System.Collections.Generic;

namespace SimpleStore.Infrastructure.Services
{
    public interface IOrderService
    {
        List<Order> GetAll();

        void SaveOrder(Order order);
    }
}
