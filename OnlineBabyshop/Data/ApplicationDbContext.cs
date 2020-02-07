using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineBabyshop.Models;

namespace OnlineBabyshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OnlineBabyshop.Models.Category> Category { get; set; }
        public DbSet<OnlineBabyshop.Models.Gender> Gender { get; set; }
        public DbSet<OnlineBabyshop.Models.Product> Product { get; set; }
        public DbSet<OnlineBabyshop.Models.Size> Size { get; set; }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62


        public DbSet<OnlineBabyshop.Models.ShoppingCartItems> ShoppingCartItems { get; set; }

        public DbSet<OnlineBabyshop.Models.OrderDetails> OrderDetails { get; set; }
        public DbSet<OnlineBabyshop.Models.Order> Order { get; set; }


<<<<<<< HEAD
=======
=======
        

        public DbSet<OnlineBabyshop.Models.ShoppingCartItems> ShoppingCartItems { get; set; }

        public DbSet<OnlineBabyshop.Models.Orders> Orders { get; set; }
        public DbSet<OnlineBabyshop.Models.OrderDetails> OrderDetails { get; set; }
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
>>>>>>> 89dfc6c724e9a8493a70b7d55b5cf46b63d3eb62
        //public DbSet<OnlineBabyshop.Models.ShoppingCart> ShoppingCart { get; set; }




    }
}
