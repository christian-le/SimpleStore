using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SimpleStore.Infrastructure.Entities;
using SimpleStore.Infrastructure.Models;
using SimpleStore.Infrastructure.Services;
using System.Collections.Generic;
using System.Linq;

namespace SimpleStore.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private Cart _cart;
        private UserManager<IdentityUser> _userManager;

        public OrderController(IOrderService orderService, Cart cart, UserManager<IdentityUser> userManager)
        {
            _orderService = orderService;
            _cart = cart;
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View(new Order());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Checkout(Order order)
        {
            if (_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (!ModelState.IsValid)
            {
                return View(order);
            }

            order.OrderDetails = new List<OrderDetail>();

            foreach (var item in _cart.Lines)
            {
                order.OrderDetails.Add(
                new OrderDetail
                {
                    ProductId = item.Product.Id,
                    Quantity = item.Quantity
                });
            }

            order.BuyerId = _userManager.GetUserId(User);
            _orderService.SaveOrder(order);

            return RedirectToAction(nameof(Completed));
        }

        public ViewResult Completed()
        {
            _cart.Clear();
            return View();
        }
    }
}