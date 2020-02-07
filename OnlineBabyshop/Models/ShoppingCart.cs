using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineBabyshop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Models
{
    public class ShoppingCart
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
        private readonly ApplicationDbContext _appDbContext;
        private ShoppingCart(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
<<<<<<< HEAD
=======
=======
        private readonly ApplicationDbContext _context;
        private ShoppingCart(ApplicationDbContext context)
        {
            _context = context;
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
        }

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItems> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Product product, int amount)
        {
            var shoppingCartItem =
<<<<<<< HEAD
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
=======
<<<<<<< HEAD
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
=======
                    _context.ShoppingCartItems.SingleOrDefault(
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
                        s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItems
                {
                    ShoppingCartId = ShoppingCartId,
<<<<<<< HEAD
                    Product = product,
                    Amount = 1
                   
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
=======
<<<<<<< HEAD
                    Product= product,
                    Amount = 1
                };

                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
=======
                    Product = product,
                    Amount = 1
                };

                _context.ShoppingCartItems.Add(shoppingCartItem);
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
            }
            else
            {
                shoppingCartItem.Amount++;
            }
<<<<<<< HEAD
            _appDbContext.SaveChanges();
=======
<<<<<<< HEAD
            _appDbContext.SaveChanges();
=======
            _context.SaveChanges();
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem =
<<<<<<< HEAD
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
=======
<<<<<<< HEAD
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
=======
                    _context.ShoppingCartItems.SingleOrDefault(
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
                        s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();
<<<<<<< HEAD
=======
=======
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _context.SaveChanges();
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62

            return localAmount;
        }

        public List<ShoppingCartItems> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
<<<<<<< HEAD
                       _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
=======
<<<<<<< HEAD
                       _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
=======
                       _context.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
                           .Include(s => s.Product)
                           .ToList());
        }

        public void ClearCart()
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
<<<<<<< HEAD
=======
=======
            var cartItems = _context
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _context.ShoppingCartItems.RemoveRange(cartItems);

            _context.SaveChanges();
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
        }

        public decimal GetShoppingCartTotal()
        {
<<<<<<< HEAD
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
=======
<<<<<<< HEAD
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
=======
            var total = _context.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
                .Select(c => c.Product.Price * c.Amount).Sum();
            return total;
        }
    }
}
