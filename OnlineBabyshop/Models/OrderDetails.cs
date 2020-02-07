using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public int OrderId { get; set; }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62

        public int ShoppingCartItemsId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
<<<<<<< HEAD
        public decimal OrderTotal { get; set; }
=======
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        public virtual List<ShoppingCartItems> ShoppingCartItems { get; set; }
    }
}

<<<<<<< HEAD
=======
=======
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public int ShoppingCartItemsId { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Orders orders { get; set; }
        public virtual ShoppingCartItems ShoppingCartItems { get; set; }
    }
}
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
