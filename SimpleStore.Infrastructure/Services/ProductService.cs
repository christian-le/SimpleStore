using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SimpleStore.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            var products = _productRepository.ListAll();

            return products;
        }

        public Product GetById(int productId)
        {
            var product = _productRepository.GetById(productId);

            return product;
        }

        public IQueryable<Product> GetByQuery(int productPage, int pageSize, out int totalItems)
        {
            var products = _productRepository.Query()
                            .OrderBy(p => p.Id)
                            .Skip((productPage - 1) * pageSize)
                            .Take(pageSize);

            totalItems = _productRepository.Query().Count();

            return products;
        }
    }
}
