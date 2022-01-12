using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianWeb
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly ICustomerBusiness customerBusiness;
      
        public Login(ICustomerBusiness customerBusiness)
        {

            this.customerBusiness = customerBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLoginSubmit_Click(object sender, EventArgs e)
        {
            string email = TextBoxLoginEmail.Text;
            string password = TextBoxLoginPassword.Text;


            if (email == "" || password == "")
            {
                LabelEmpty.Visible = true;
                return;
            }

            if (!customerBusiness.LoginValidation(email, password))
            {
                LabelLoginError.Visible = true;
                return;
            }
            else
            {
                Customer customer = GetCustomer(email, password);

                Session["User"] = customer;

                Response.Redirect("~/Default");
            
            }

        }

        public Customer GetCustomer(string email, string password)
        {
            List<Customer> customers = customerBusiness.GetCustomers();

            Customer customer = new Customer();
            foreach (var item in customers)
            {
                if (item.Email == email && item.Password == password)
                    customer = item;
            }

            return customer;
        
        }
    }
}