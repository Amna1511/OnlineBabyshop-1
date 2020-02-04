using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using OnlineBabyshop.Data.Interfaces;
=======
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineBabyshop.Data.Repositories;
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
using OnlineBabyshop.Models;

namespace OnlineBabyshop.Controllers
{
    public class OrdersController : Controller
    {
<<<<<<< HEAD
=======

>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
        private readonly IOrdersRepository _ordersRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(IOrdersRepository ordersRepository, ShoppingCart shoppingCart)
        {
            _ordersRepository = ordersRepository;
            _shoppingCart = shoppingCart;
        }

<<<<<<< HEAD

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
=======
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
       
        public IActionResult Checkout(Orders orders)
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your card is empty, add some drinks first");
            }

            if (ModelState.IsValid)
            {
<<<<<<< HEAD
                _ordersRepository.CreateOrderDetails(orderDetails);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(orderDetails);
=======
                _ordersRepository.CreateOrder(orders);
                //_shoppingCart.ClearCart();
               
                return RedirectToAction("CheckoutComplete", orders.OrderId);
            }

            return View(orders);
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
            return View();
        }
<<<<<<< HEAD
=======

















>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
    }
}