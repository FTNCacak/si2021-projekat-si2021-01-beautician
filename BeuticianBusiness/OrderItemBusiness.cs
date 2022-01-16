using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianBusiness
{
    public class OrderItemBusiness : IOrderItemBusiness
    {
        private readonly IOrderItemRepository orderItemRepository;

        public OrderItemBusiness(IOrderItemRepository orderItemRepository)
        {
            this.orderItemRepository = orderItemRepository;
        }

        public void InsertOrderItem(OrderItem orderItem)
        {
            orderItemRepository.InsertOrderItem(orderItem);
        }

        public List<OrderItem> GetOrderItems()
        {
            return orderItemRepository.GetOrderItems();
        }

    }
}
