using SimpleStore.Infrastructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleStore.Infrastructure.Services
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int productId);
    }
}
