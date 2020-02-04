<<<<<<< HEAD
﻿using OnlineBabyshop.Data.Interfaces;
using OnlineBabyshop.Models;
=======
﻿using OnlineBabyshop.Models;
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Data.Repositories
{
<<<<<<< HEAD
    public class OrdersRepository : IOrdersRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;


        public OrdersRepository(ApplicationDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
=======
    public class OrdersRepository: IOrdersRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly ShoppingCart _shoppingCart;


        public OrdersRepository(ApplicationDbContext context, ShoppingCart shoppingCart)
        {
            _context = context;
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
            _shoppingCart = shoppingCart;
        }


<<<<<<< HEAD
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDbContext.Order.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            
            _appDbContext.SaveChanges();
=======
        public int CreateOrder(Orders orders)
        {
            orders.OrderPlaced = DateTime.Now;

            _context.Orders.Add(orders);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetails = new OrderDetails()
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
<<<<<<< HEAD
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Product.Price
                };

                CreateOrderDetails(orderDetails);
            }

            
        }


        public void CreateOrderDetails(OrderDetails orderDetails)
        {
            //order.OrderPlaced = DateTime.Now;
            var order = _appDbContext.Order.ToList();
            int orderId = 0; 
            foreach (var item in order)
            {
                orderId = item.OrderId;
            }
            //int orderId = order.LastOrDefault().OrderId;

            orderDetails.OrderId = orderId;
            _appDbContext.OrderDetails.Add(orderDetails);

            //var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            //foreach (var shoppingCartItem in shoppingCartItems)
            //{
            //    var Details = new OrderDetails()
            //    {
            //        Amount = shoppingCartItem.Amount,
            //        ProductId = shoppingCartItem.Product.ProductId,
            //        OrderId= orderDetails.OrderId,
            //        ShoppingCartItemsId = shoppingCartItem.ShoppingCartItemsId,
            //        Price = shoppingCartItem.Product.Price
            //    };

            //    _appDbContext.OrderDetails.Add(Details);
            //}

            _appDbContext.SaveChanges();
        }
=======
                    OrderId = orders.OrderId,
                    Price = shoppingCartItem.Product.Price,
                    ShoppingCartItemsId = shoppingCartItem.ShoppingCartItemsId
                };

                _context.OrderDetails.Add(orderDetails);
                
            }

            _context.SaveChanges();
          
            return orders.OrderId;
        }






>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a









    }
}
