using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Shared.Interfaces;
using Shared.Models;
using System.Net.Mail;
namespace BeuticianWeb
{
    public partial class Register : System.Web.UI.Page
    {

        private readonly ICustomerBusiness customerBusiness;
        private readonly IOrderItemBusiness orderItemBusiness;
        private readonly IOrderBusiness orderBusiness;
        private readonly IProductBusiness productBusiness;
        public Register(ICustomerBusiness customerBusiness, IOrderItemBusiness orderItemBusiness, IOrderBusiness orderBusiness, IProductBusiness productBusiness)
        {

            this.customerBusiness = customerBusiness;
            this.orderItemBusiness = orderItemBusiness;
            this.orderBusiness = orderBusiness;
            this.productBusiness = productBusiness;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBoxZipCode.Enabled = false;

            TextBoxZipCode.Text = "11000";
            DropDownListCity.Items.Clear();
            
            List<string> cities = new List<string>() { "Beograd", "Novi Sad", "Niš", "Kragujevac", "Subotica", "Zrenjanin", "Pančevo", "Čačak", "Kruševac", "Kraljevo", "Novi Pazar", "Smederevo", "Leskovac", "Užice", "Vranje", "Valjevo", "Šabac", "Sombor", "Požarevac", "Pirot", "Zaječar", "Kikinda", "Sremska Mitrovica", "Jagodina", "Vršac", "Bor", "Prokuplje", "Loznica" };

            foreach (var item in cities)
            {
                DropDownListCity.Items.Add(new ListItem(item));

            }

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            string Name = TextBoxName.Text;
            string Surname = TextBoxSurname.Text;
            string Address = TextBoxAddress.Text;
            string Phone = TextBoxPhone.Text;

            string Email = TextBoxEmail.Text;
            string City = DropDownListCity.SelectedItem.Value;
            string ZipCode = TextBoxZipCode.Text;

            string Password = TextBoxPassword.Text;
            string ConfirmPassword = TextBoxConfirmPassword.Text;


            if (Name == "" || Surname == "" || Address == "" || Email == "" || Password == "" || ConfirmPassword == "")
            {
                LabelErrorEmpty.Visible = true;
                return;
            }
            if (customerBusiness.CustomerExists(Email)) {
                LabelErrorCustomerExists.Visible = true;
                return;
            }
            if (!ValidateEmail(Email))
            {
                LabelErrorEmail.Visible = true;
                return;
            }
            if (Password.Length < 8)
            {
                LabelErrorPassword.Visible = true;
                return;
            }
            if (Password != ConfirmPassword)
            {
                LabelErrorConfirmPassword.Visible = true;
                return;
            }
            else
            {
                Customer customer = new Customer(1, Name, Surname, Address, City, Phone, Email, ZipCode, Password);
                customerBusiness.InsertCustomer(customer);
                Response.Redirect("~/SuccessRegistration");
                
            }


            
           

        }

        public bool ValidateEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


    }
}