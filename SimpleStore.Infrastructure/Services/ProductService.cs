using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;
using System.Collections.Generic;

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
    }
}
