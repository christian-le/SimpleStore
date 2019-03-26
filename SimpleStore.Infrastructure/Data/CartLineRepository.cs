using SimpleStore.Infrastructure.Interfaces;
using SimpleStore.Infrastructure.Models;

namespace SimpleStore.Infrastructure.Data
{
    public class CartLineRepository : EfRepository<CartLine>, ICartLineRepository
    {
        public CartLineRepository(SinpleStoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
