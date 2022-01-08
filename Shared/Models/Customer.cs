using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
  public  class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Customer() { }

        public Customer(int customerId, string name, string surname, string address, string city, string phone, string email, string username, string password)
        {
            CustomerId = customerId;
            Name = name;
            Surname = surname;
            Address = address;
            City = city;
            Phone = phone;
            Email = email;
            Username = username;
            Password = password;
        }
    }
}
