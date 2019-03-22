using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;

namespace SimpleStore.Infrastructure.Data
{
    public class ProductRepository : EfRepository<Product>, IProductRepository
    {
        public ProductRepository(SinpleStoreDbContext dbContext) : base(dbContext)
        {
        }
    }
}
