using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Models;
using Shared.Interfaces;
using System.Threading;

namespace BeuticianDesktop
{
    public partial class AdminLoginForm : Form
    {

        private readonly IAdminBusiness adminBusiness;
        private readonly ICategoryBusiness categoryBusiness;
        private readonly IManufacturerBusiness manufacturerBusiness;
        private readonly IProductBusiness productBusiness;


        public AdminLoginForm(IAdminBusiness adminBusiness, ICategoryBusiness categoryBusiness, IManufacturerBusiness manufacturerBusiness, IProductBusiness productBusiness)
        {
            this.adminBusiness = adminBusiness;
            this.categoryBusiness = categoryBusiness;
            this.manufacturerBusiness = manufacturerBusiness;
            this.productBusiness = productBusiness;
            InitializeComponent();
        }

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (username == "" || password == "")
            {
                labelError.Text = "Sva polja moraju biti popunjena!";
                labelError.Visible = true;
                return;
            }
            if (!adminBusiness.AdminLoginValidation(username, password))
            {
                labelError.Text = "Neispravni unos!";
                labelError.Visible = true;
                return;
            }


            List<Product> products = productBusiness.GetProducts();
            List<Category> categories = categoryBusiness.GetCategories();
            List<Manufacturer> manufacturers = manufacturerBusiness.GetManufacturers();

            Thread thread = new Thread(() => OpenNewForm(categoryBusiness, manufacturerBusiness, productBusiness, products, categories, manufacturers));
            thread.Start();
            this.Dispose();

        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void OpenNewForm(ICategoryBusiness categoryBusiness, IManufacturerBusiness manufacturerBusiness, IProductBusiness productBusiness, List<Product> products, List<Category> categories, List<Manufacturer> manufacturers)
        {
            Application.Run(new AdminPanelForm(categoryBusiness, manufacturerBusiness, productBusiness, products, categories, manufacturers));
        }

    }
}
