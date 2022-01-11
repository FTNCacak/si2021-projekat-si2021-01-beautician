using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianBusiness
{
    public class CustomerBusiness : ICustomerBusiness
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerBusiness(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public void InsertCustomer(Customer customer)
        {

            customerRepository.InsertCustomer(customer);
        }

        public List<Customer> GetCustomers()
        {
            return customerRepository.GetCustomers();
        }

        public bool CustomerExists(string email)
        {
            List<Customer> customers = GetCustomers();

            if (customers.Count == 0)
                return false;

            foreach (var customer in customers)
            {
                if (customer.Email == email)
                    return true;
            }

            return false;
        }

        public bool LoginValidation(string email, string password)
        {
            List<Customer> customers = GetCustomers();

            foreach (var customer in customers)
            {
                if (customer.Email == email && customer.Password == password)
                    return true;
            }

            return false;
        }


    }
}
