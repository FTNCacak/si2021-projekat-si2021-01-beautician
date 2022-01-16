using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;

namespace Shared.Interfaces
{
    public interface ICustomerBusiness
    {
        void InsertCustomer(Customer customer);
        List<Customer> GetCustomers();
        bool CustomerExists(string email);
        bool LoginValidation(string email, string password);
    }
}
