using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianData
{
    public class AdminRepository : IAdminRepository
    {

        // Metoda za selektovanje svih podataka iz tabele admin

        public List<Admin> GetAdmins()
        {
            List<Admin> admins = new List<Admin>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "SELECT * FROM Admins";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    int AdminId = sqlDataReader.GetInt32(0);
                    string Name = sqlDataReader.GetString(1);
                    string Surname = sqlDataReader.GetString(2);
                    string Username = sqlDataReader.GetString(3);
                    string Password = sqlDataReader.GetString(4);
                    Admin admin = new Admin(AdminId, Name, Surname, Username, Password);

                    admins.Add(admin);
                }


            }


            return admins;
        }
    }
}
