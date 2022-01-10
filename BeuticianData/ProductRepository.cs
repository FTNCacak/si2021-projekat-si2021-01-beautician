using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianData
{
    public class ProductRepository : IProductRepository
    {
        // Metoda za unos podataka u tabelu Products
        public void InsertProduct(Product product)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "INSERT INTO Products(Name, Price, Amount, Description, CategoryId, ManufacturerId) VALUES(@Name, @Price, @Amount, @Description, @CategoryId, @ManufacturerId);";
                sqlCommand.Parameters.AddWithValue("@Name", product.Name);
                sqlCommand.Parameters.AddWithValue("@Price", product.Price);
                sqlCommand.Parameters.AddWithValue("@Amount", product.Amount);
                sqlCommand.Parameters.AddWithValue("@Description", product.Description);
                sqlCommand.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                sqlCommand.Parameters.AddWithValue("@ManufacturerId", product.ManufacturerId);

                sqlCommand.ExecuteNonQuery();

            }
        }

        // Metoda za brisanje podataka iz tabele Products
        public void DeleteProduct(int productId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "DELETE FROM Products WHERE ProductId=@ProductId";
                sqlCommand.Parameters.AddWithValue("@ProductId", productId);



                sqlCommand.ExecuteNonQuery();

            }
        }


        // Metoda za azuriranje podataka u tabeli Products
        public void UpdateProduct(Product product)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "UPDATE Products SET Name=@Name, Price=@Price, Amount=@Amount, Description=@Description, CategoryId=@CategoryId, ManufacturerId=@ManufacturerId WHERE ProductId=@ProductId";
                sqlCommand.Parameters.AddWithValue("@Name", product.Name);
                sqlCommand.Parameters.AddWithValue("@Price", product.Price);
                sqlCommand.Parameters.AddWithValue("@Amount", product.Amount);
                sqlCommand.Parameters.AddWithValue("@Description", product.Description);
                sqlCommand.Parameters.AddWithValue("@CategoryId", product.CategoryId);
                sqlCommand.Parameters.AddWithValue("@ManufacturerId", product.ManufacturerId);
                sqlCommand.Parameters.AddWithValue("@ProductId", product.ProductId);

                sqlCommand.ExecuteNonQuery();

            }
        }

        // Metoda za vracanje svih podataka iz tabele Products

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Products;";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    int ProductId = sqlDataReader.GetInt32(0);
                    string Name = sqlDataReader.GetString(1);
                    decimal Price = sqlDataReader.GetDecimal(2);
                    int Amount = sqlDataReader.GetInt32(3);
                    string Description = sqlDataReader.GetString(4);
                    int CategoryId = sqlDataReader.GetInt32(5);
                    int ManufacturerId = sqlDataReader.GetInt32(6);


                    Product product = new Product(ProductId, Name, Price, Amount, Description, CategoryId, ManufacturerId);

                    products.Add(product);
                }


            }

            return products;

        }

    }
}
