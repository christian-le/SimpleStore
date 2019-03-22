using SimpleStore.Infrastructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleStore.Infrastructure.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();

        Task<Product> GetById(int productId);
    }
}
