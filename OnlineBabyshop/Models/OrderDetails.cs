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

        public int ShoppingCartItemsId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
        public virtual List<ShoppingCartItems> ShoppingCartItems { get; set; }
    }
}

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
