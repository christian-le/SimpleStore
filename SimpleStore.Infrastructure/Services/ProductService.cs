using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimpleStore.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAll()
        {
            var products = await _productRepository.ListAllAsync();

            return products;
        }

        public async Task<Product> GetById(int productId)
        {
            var product = await _productRepository.GetByIdAsync(productId);

            return product;
        }
    }
}
