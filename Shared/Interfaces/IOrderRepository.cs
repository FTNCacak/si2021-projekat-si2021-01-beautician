using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
   public interface IOrderRepository
    {

        void InsertOrder(Order order);
        List<Order> GetOrders();
    }
}
