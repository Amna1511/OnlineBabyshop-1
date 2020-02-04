using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Models
{
    public class ShoppingCartItems
    {
        public int ShoppingCartItemsId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
