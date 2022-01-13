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
    public class OrderRepository : IOrderRepository
    {
        // Metoda za unos podataka u tabelu Orders
        public void InsertOrder(Order order)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "INSERT INTO Orders(CustomerId, Date) VALUES(@CustomerId, @Date);";
                sqlCommand.Parameters.AddWithValue("@CustomerId", order.CustomerId);
                sqlCommand.Parameters.AddWithValue("@Date", order.Date);



                sqlCommand.ExecuteNonQuery();

            }
        }


        // Metoda za vracanje svih podataka iz tabele Orders
        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Orders";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    int OrderId = sqlDataReader.GetInt32(0);
                    int CustomerId = sqlDataReader.GetInt32(1);

                    DateTime Date = sqlDataReader.GetDateTime(2);

                    Order order = new Order(OrderId, CustomerId, Date);

                    orders.Add(order);
                }


            }

            return orders;

        }

    }
}
