using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianBusiness
{
    public class OrderBusiness : IOrderBusiness
    {
        private readonly IOrderRepository orderRepository;

        public OrderBusiness(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public void InsertOrder(Order order)
        {
            orderRepository.InsertOrder(order);
        }

        public List<Order> GetOrders()
        {

            return orderRepository.GetOrders();
        }

        public Order GetSpecificOrder(int CustomerId, DateTime date)
        {
            Order order = new Order();

            List<Order> orders = GetOrders();

            foreach (Order item in orders)
            {
                if (item.CustomerId == CustomerId && item.Date == date)
                    order = item;
            }


            return order;
        }




    }
}
