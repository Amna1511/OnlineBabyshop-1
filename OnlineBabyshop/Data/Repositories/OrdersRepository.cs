using OnlineBabyshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Data.Repositories
{
    public class OrdersRepository: IOrdersRepository
    {

        private readonly ApplicationDbContext _context;
        private readonly ShoppingCart _shoppingCart;


        public OrdersRepository(ApplicationDbContext context, ShoppingCart shoppingCart)
        {
            _context = context;
            _shoppingCart = shoppingCart;
        }


        public int CreateOrder(Orders orders)
        {
            orders.OrderPlaced = DateTime.Now;

            _context.Orders.Add(orders);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetails = new OrderDetails()
                {
                    Amount = shoppingCartItem.Amount,
                    ProductId = shoppingCartItem.Product.ProductId,
                    OrderId = orders.OrderId,
                    Price = shoppingCartItem.Product.Price,
                    ShoppingCartItemsId = shoppingCartItem.ShoppingCartItemsId
                };

                _context.OrderDetails.Add(orderDetails);
                
            }

            _context.SaveChanges();
          
            return orders.OrderId;
        }















    }
}
