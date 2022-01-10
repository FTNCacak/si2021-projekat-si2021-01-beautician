using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using System.Data.SqlClient;
using Shared.Interfaces;
namespace BeuticianData
{
  public class CategoryRepository : ICategoryRepository
    {
        // Metoda za unos podataka u tabelu Categories
        public void InsertCategory(Category category)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "INSERT INTO Categories(Name, Description) VALUES(@Name, @Description);";
                sqlCommand.Parameters.AddWithValue("@Name", category.Name);
                sqlCommand.Parameters.AddWithValue("@Description", category.Description);


                sqlCommand.ExecuteNonQuery();

            }
        }

        // Metoda za brisanje podataka iz tabele Categories
        public void DeleteCategory(int categoryId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "DELETE FROM Categories WHERE CategoryId=@CategoryId";
                sqlCommand.Parameters.AddWithValue("@CategoryId", categoryId);
               


                sqlCommand.ExecuteNonQuery();

            }
        }


        // Metoda za azuriranje podataka u tabeli Categories
        public void UpdateCategory(Category category)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "UPDATE Categories SET Name=@Name, SET Description=@Description WHERE CategoryId=@CategoryId;";
                sqlCommand.Parameters.AddWithValue("@CategoryId", category.CategoryId);
                sqlCommand.Parameters.AddWithValue("@Name", category.Name);
                sqlCommand.Parameters.AddWithValue("@Description", category.Description);


                sqlCommand.ExecuteNonQuery();

            }
        }

        // Metoda za vracanje svih podataka iz tabele Categories

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Categories";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    int CategoryId = sqlDataReader.GetInt32(0);
                    string Name = sqlDataReader.GetString(1);
                    string Description = sqlDataReader.GetString(2);
                   
                    Category category = new Category(CategoryId, Name, Description);

                    categories.Add(category);
                }


            }

            return categories;

        }





    }
}
