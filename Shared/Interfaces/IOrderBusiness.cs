using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface IOrderBusiness
    {
        void InsertOrder(Order order);
        List<Order> GetOrders();
        Order GetSpecificOrder(int CustomerId, DateTime date);
    }
}
