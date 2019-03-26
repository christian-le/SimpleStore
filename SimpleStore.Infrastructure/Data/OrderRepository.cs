using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;

namespace SimpleStore.Infrastructure.Data
{
    public class OrderRepository : EfRepository<Order>, IOrderRepository
    {
        public OrderRepository(SinpleStoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
