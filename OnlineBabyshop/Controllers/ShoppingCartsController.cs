using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineBabyshop.Data;
using OnlineBabyshop.Data.Interfaces;
using OnlineBabyshop.Models;

namespace OnlineBabyshop.Controllers
{
    public class ShoppingCartsController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IProductsRepository _productsRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartsController(IProductsRepository productsRepository, ShoppingCart shoppingCart)
        {
            _productsRepository = productsRepository;
            _shoppingCart = shoppingCart;
        }

        //// GET: ShoppingCarts
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.ShoppingCart.ToListAsync());
        //}

        //// GET: ShoppingCarts/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var shoppingCart = await _context.ShoppingCart
        //        .FirstOrDefaultAsync(m => m.ShoppingCartId == id);
        //    if (shoppingCart == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(shoppingCart);
        //}

      
        

       

        //private bool ShoppingCartExists(string id)
        //{
        //    return _context.ShoppingCart.Any(e => e.ShoppingCartId == id);
        //}



        


        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartView = new ShoppingCartView
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartView);
        }


        public RedirectToActionResult AddToShoppingCart(int productId)
        {
            var selectedProduct = _productsRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int productId)
        {
            var selectedProduct = _productsRepository.Products.FirstOrDefault(p => p.ProductId == productId);
            if (selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }


















    }
}
