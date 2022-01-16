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
   public class ManufacturerRepository : IManufacturerRepository
    {
        // Metoda za unos podataka u tabelu Manufacturers
        public void InsertManufacturer(Manufacturer manufacturer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = " INSERT INTO Manufacturers(Name) VALUES(@Name);";
                sqlCommand.Parameters.AddWithValue("@Name", manufacturer.Name);

                sqlCommand.ExecuteNonQuery();

            }
        }

        // Metoda za brisanje podataka iz tabele Manufacturers
        public void DeleteManufacturer(int manufacturerId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "DELETE FROM Manufacturers WHERE ManufacturerId=@ManufacturerId";
                sqlCommand.Parameters.AddWithValue("@ManufacturerId", manufacturerId);



                sqlCommand.ExecuteNonQuery();

            }
        }


        // Metoda za azuriranje podataka u tabeli Manufacturers
        public void UpdateManufacturer(Manufacturer manufacturer)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "UPDATE Manufacturers SET Name=@Name WHERE ManufacturerId=@ManufacturerId;";
                sqlCommand.Parameters.AddWithValue("@ManufacturerId", manufacturer.ManufacturerId);
                sqlCommand.Parameters.AddWithValue("@Name", manufacturer.Name);
              


                sqlCommand.ExecuteNonQuery();

            }
        }

        // Metoda za vracanje svih podataka iz tabele Manufacturers

        public List<Manufacturer> GetManufacturers()
        {
            List<Manufacturer> manufacturers = new List<Manufacturer>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Manufacturers";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    int ManufacturerId = sqlDataReader.GetInt32(0);
                    string Name = sqlDataReader.GetString(1);


                    Manufacturer manufacturer = new Manufacturer(ManufacturerId, Name);

                    manufacturers.Add(manufacturer);
                }


            }

            return manufacturers;

        }
    }
}
