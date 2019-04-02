using SimpleStore.Infrastructure.Entities;
using System.Collections.Generic;
using System.Linq;

namespace SimpleStore.Infrastructure.Services
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int productId);

        IQueryable<Product> GetByQuery(int productPage, int pageSize, out int totalItems);
    }
}
