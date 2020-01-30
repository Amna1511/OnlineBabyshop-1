using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineBabyshop.Data.Repositories;
using OnlineBabyshop.Models;

namespace OnlineBabyshop.Controllers
{
    public class OrdersController : Controller
    {

        private readonly IOrdersRepository _ordersRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(IOrdersRepository ordersRepository, ShoppingCart shoppingCart)
        {
            _ordersRepository = ordersRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
       
        public IActionResult Checkout(Orders orders)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some drinks first");
            }

            if (ModelState.IsValid)
            {
                _ordersRepository.CreateOrder(orders);
                //_shoppingCart.ClearCart();
               
                return RedirectToAction("CheckoutComplete", orders.OrderId);
            }

            return View(orders);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
            return View();
        }

















    }
}