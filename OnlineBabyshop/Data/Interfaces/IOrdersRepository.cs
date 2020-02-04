using OnlineBabyshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace OnlineBabyshop.Data.Interfaces
{
    public interface IOrdersRepository
    {
        void CreateOrder(Order order);
        void CreateOrderDetails(OrderDetails orderDetails);
=======
namespace OnlineBabyshop.Data.Repositories
{
   public interface IOrdersRepository
    {
        int CreateOrder(Orders orders);
>>>>>>> f59acac8d55b8772f369c689cbacb105318e8a3a
    }
}
