using Microsoft.AspNetCore.Mvc;
using SimpleStore.Infrastructure.Services;
using SimpleStore.Models;
using System.Linq;

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
            var products = _productService.GetAll();

            var model = new ProductListViewModel()
            {
                Products = products.OrderBy(p => p.Id)
                .Skip((productPage - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemPerPage = pageSize,
                    TotalItems = products.Count()
                }
            };

            return View(model);
        }

    }
}