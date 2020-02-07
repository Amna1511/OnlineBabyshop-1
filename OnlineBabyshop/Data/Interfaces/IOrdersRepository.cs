using OnlineBabyshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBabyshop.Data.Repositories
{
   public interface IOrdersRepository
    {
        int CreateOrder(Orders orders);

    }
}
