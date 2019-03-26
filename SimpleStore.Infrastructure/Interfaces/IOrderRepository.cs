using SimpleStore.Infrastructure.Entities;

namespace SimpleStore.Infrastructure.Interfaces
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
