using Microsoft.AspNetCore.Mvc;
using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Models;
using SimpleStore.Infrastructure.Services;
using System.Linq;

namespace SimpleStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private Cart _cart;

        public OrderController(IOrderService orderService, Cart cart)
        {
            _orderService = orderService;
            _cart = cart;
        }

        public IActionResult Checkout()
        {
            return View(new Order());
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if(_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if(ModelState.IsValid)
            {
                _orderService.SaveOrder(order);

                //order.Lines = _cart.Lines.ToArray();

                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(order);
            }
        }

        public ViewResult Completed()
        {
            _cart.Clear();
            return View();
        }
    }
}