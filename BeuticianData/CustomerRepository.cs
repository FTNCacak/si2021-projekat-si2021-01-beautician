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
    public class CustomerRepository : ICustomerRepository
    {
        // Metoda za unos podataka u tabelu Customers
        public void InsertCustomer(Customer customer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "INSERT INTO Customers(Name, Surname, Address, City, Phone, Email, Password, PostCode) VALUES(@Name, @Surname, @Address, @City, @Phone, @Email, @Password, @PostCode);";
                sqlCommand.Parameters.AddWithValue("@Name", customer.Name);
                sqlCommand.Parameters.AddWithValue("@Surname", customer.Surname);

                sqlCommand.Parameters.AddWithValue("@Address", customer.Address);
                sqlCommand.Parameters.AddWithValue("@City", customer.City);

                sqlCommand.Parameters.AddWithValue("@Phone", customer.Phone);
                sqlCommand.Parameters.AddWithValue("@Email", customer.Email);

                sqlCommand.Parameters.AddWithValue("@Password", customer.Password);
                sqlCommand.Parameters.AddWithValue("@PostCode", customer.PostCode);


                sqlCommand.ExecuteNonQuery();

            }
        }




        // Metoda za vracanje svih podataka iz tabele Customers

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Customers";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    int CustomerId = sqlDataReader.GetInt32(0);

                    string Name = sqlDataReader.GetString(1);
                    string Surname = sqlDataReader.GetString(2);
                    string Address = sqlDataReader.GetString(3);
                    string City = sqlDataReader.GetString(4);
                    string Phone = sqlDataReader.GetString(5);
                    string Email = sqlDataReader.GetString(6);
                    string Password = sqlDataReader.GetString(7);
                    string PostCode = sqlDataReader.GetString(8);


                    Customer customer = new Customer(CustomerId, Name, Surname, Address, City, Phone, Email, PostCode, Password);

                    customers.Add(customer);
                }


            }

            return customers;

        }

    }
}
