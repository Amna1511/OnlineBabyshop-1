using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBabyshop.Data;
using OnlineBabyshop.Data.Interfaces;
=======
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using OnlineBabyshop.Data.Interfaces;
=======
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineBabyshop.Data.Repositories;
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
using OnlineBabyshop.Models;

namespace OnlineBabyshop.Controllers
{
    public class OrdersController : Controller
    {
<<<<<<< HEAD
        private readonly IOrdersRepository _ordersRepository;
        private readonly ShoppingCart _shoppingCart;
        private readonly ApplicationDbContext _context;
      
        public OrdersController(IOrdersRepository ordersRepository, ShoppingCart shoppingCart, ApplicationDbContext context)
        {
            _ordersRepository = ordersRepository;
            _shoppingCart = shoppingCart;
            _context = context;
        }


        public IActionResult Checkout()
        {
            return View();
        }

        

        public IActionResult CheckoutOne()
        {
            return View();
        }

        [HttpPost]
=======
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
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62

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

<<<<<<< HEAD

        //[HttpPost]
        //public IActionResult CheckoutOne(OrderDetails orderDetails)
        //{
        //    var items = _shoppingCart.GetShoppingCartItems();
        //    _shoppingCart.ShoppingCartItems = items;
        //    if (_shoppingCart.ShoppingCartItems.Count == 0)
        //    {
        //        ModelState.AddModelError("", "Your card is empty, add some drinks first");
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        _ordersRepository.CreateOrderDetails(orderDetails);
        //        _shoppingCart.ClearCart();
        //        return RedirectToAction("CheckoutComplete");
        //    }

        //    return View(orderDetails);
        //}

        public async Task<IActionResult> CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! :) ";
            ////ViewBag.OrderDetails = _context.OrderDetails.LastOrDefault().OrderDetailsId;
            ///

           






            return View();
        }



        //public ViewResult CheckoutComplete()
        //{
        //    var items = _shoppingCart.GetShoppingCartItems();
        //    _shoppingCart.ShoppingCartItems = items;

        //    var orderViewModel = new OrderViewModel
        //    {
        //        ShoppingCart = _shoppingCart,


        //    };
        //    return View(orderViewModel);
        //}


        //[HttpPost]
        //public IActionResult CheckoutComplete (OrderDetails orderDetails)
        //{


        //    return View("CheckoutComplete", orderDetails.OrderId);
        //}
=======
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











>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62






<<<<<<< HEAD
=======
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
    }
}