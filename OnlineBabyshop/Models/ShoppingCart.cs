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
        private readonly ApplicationDbContext _appDbContext;
        private ShoppingCart(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
=======
        private readonly ApplicationDbContext _context;
        private ShoppingCart(ApplicationDbContext context)
        {
            _context = context;
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
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
                    _context.ShoppingCartItems.SingleOrDefault(
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
                        s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItems
                {
                    ShoppingCartId = ShoppingCartId,
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
            }
            else
            {
                shoppingCartItem.Amount++;
            }
<<<<<<< HEAD
            _appDbContext.SaveChanges();
=======
            _context.SaveChanges();
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
        }

        public int RemoveFromCart(Product product)
        {
            var shoppingCartItem =
<<<<<<< HEAD
                    _appDbContext.ShoppingCartItems.SingleOrDefault(
=======
                    _context.ShoppingCartItems.SingleOrDefault(
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
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
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();
=======
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _context.SaveChanges();
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a

            return localAmount;
        }

        public List<ShoppingCartItems> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
<<<<<<< HEAD
                       _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
=======
                       _context.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
                           .Include(s => s.Product)
                           .ToList());
        }

        public void ClearCart()
        {
<<<<<<< HEAD
            var cartItems = _appDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
=======
            var cartItems = _context
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _context.ShoppingCartItems.RemoveRange(cartItems);

            _context.SaveChanges();
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
        }

        public decimal GetShoppingCartTotal()
        {
<<<<<<< HEAD
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
=======
            var total = _context.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
                .Select(c => c.Product.Price * c.Amount).Sum();
            return total;
        }
    }
}
