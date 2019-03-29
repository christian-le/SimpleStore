using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;

namespace SimpleStore.Infrastructure.Data
{
    public class OrderDetailRepository : EfRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(SinpleStoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
