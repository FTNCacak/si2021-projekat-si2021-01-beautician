using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class OrderItem
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }

        public OrderItem() { }

        public OrderItem(int productId, int orderId, int quantity)
        {
            ProductId = productId;
            OrderId = orderId;
            Quantity = quantity;
        }
    }
}
