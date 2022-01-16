using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;
using System.Data.SqlClient;

namespace BeuticianData
{
   public class OrderItemRepository : IOrderItemRepository
    {


        // Metoda za unos podataka u tabelu OrderItems
        public void InsertOrderItem(OrderItem orderItem)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "INSERT INTO Order_Items(ProductId, OrderId, Quantity) VALUES(@ProductId, @OrderId, @Quantity);";
                sqlCommand.Parameters.AddWithValue("@ProductId", orderItem.ProductId);
                sqlCommand.Parameters.AddWithValue("@OrderId", orderItem.OrderId);
                sqlCommand.Parameters.AddWithValue("@Quantity", orderItem.Quantity);



                sqlCommand.ExecuteNonQuery();

            }
        }


        // Metoda za vracanje svih podataka iz tabele Orders
        public List<OrderItem> GetOrderItems()
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Orders";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    int ProductId = sqlDataReader.GetInt32(0);
                    int OrderId = sqlDataReader.GetInt32(1);
                    int Quantity = sqlDataReader.GetInt32(2);

               
                    OrderItem orderItem = new OrderItem(ProductId, OrderId, Quantity);

                    orderItems.Add(orderItem);
                }


            }

            return orderItems;
        }

    }
}
