using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBabyshop.Data;
using OnlineBabyshop.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OnlineBabyshop.Data.Repositories;
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
        public IActionResult CheckoutOne(OrderDetails orderDetails)
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

                _ordersRepository.CreateOrderDetails(orderDetails);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(orderDetails);

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
