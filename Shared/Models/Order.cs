using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }

        public Order() { }

        public Order(int orderId, int customerId, DateTime date)
        {
            OrderId = orderId;
            CustomerId = customerId;
            Date = date;
        }
    }
}
