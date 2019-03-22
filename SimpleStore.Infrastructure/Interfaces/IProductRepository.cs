using SimpleStore.Infrastructure.Entities;

namespace SimpleStore.Infrastructure.Interfaces
{
    public interface IProductRepository : IAsyncRepository<Product>
    {
    }
}
