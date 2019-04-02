using Microsoft.AspNetCore.Mvc;
using SimpleStore.Infrastructure.Services;
using SimpleStore.Models;

namespace SimpleStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public int pageSize = 3;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet()]
        public IActionResult Index(int productPage = 1)
        {
            int totalItems = 0;

            var products = _productService.GetByQuery(productPage, pageSize, out totalItems);

            var model = new ProductListViewModel()
            {
                Products = products,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemPerPage = pageSize,
                    TotalItems = totalItems
                }
            };

            return View(model);
        }

    }
}