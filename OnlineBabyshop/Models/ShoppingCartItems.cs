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
<<<<<<< HEAD

        //quantity = amount
        public int Amount { get; set; }
        public decimal OrderTotal { get; set; }
        //public int OrderDetailsId { get; set; }
        //public virtual OrderDetails OrderDetails { get; set; }
=======
        public int Amount { get; set; }
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
        public string ShoppingCartId { get; set; }
    }
}
