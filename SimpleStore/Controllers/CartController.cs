using Microsoft.AspNetCore.Mvc;
using SimpleStore.Infrastructure.Services;
using SimpleStore.Models;

namespace SimpleStore.Controllers
{
    public class CartController : Controller
    {
        private IProductService _productService;
        private Cart _cart;

        public CartController(IProductService productService, Cart cart)
        {
            _productService = productService;
            _cart = cart;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel {
                Cart = _cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int Id, string returnUrl)
        {
            var product = _productService.GetById(Id).Result;

            if (product != null)
            {
                _cart.AddItem(product, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId, string returnUrl)
        {
            var product = _productService.GetById(productId).Result;

            if (product != null)
            {
                _cart.RemoveLine(product);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
    }
}