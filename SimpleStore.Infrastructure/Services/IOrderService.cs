using SimpleStore.Infrastructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleStore.Infrastructure.Services
{
    public interface IOrderService
    {
        Task<List<Order>> GetAll();

        Task SaveOrder(Order order);
    }
}
