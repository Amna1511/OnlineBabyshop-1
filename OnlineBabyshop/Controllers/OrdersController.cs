using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBabyshop.Data.Interfaces;
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


        //public IActionResult CheckoutOne()
        //{
        //    return View();
        //}

        //[HttpPost]

        public IActionResult Checkout(Order order)
        {
            OrderDetails orderDetails = new OrderDetails();
           
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some drinks first");
            }

            if (ModelState.IsValid)
            {
                orderDetails.ShoppingCartItems = items;
               _ordersRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order);
        }

        public IActionResult CheckoutOne(OrderDetails orderDetails)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some drinks first");
            }

            if (ModelState.IsValid)
            {
                _ordersRepository.CreateOrderDetails(orderDetails);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(orderDetails);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
            return View();
        }
    }
}