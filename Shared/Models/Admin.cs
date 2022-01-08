using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Admin() { }

        public Admin(int adminId, string name, string surname, string username, string password)
        {
            AdminId = adminId;
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }
    }
}
