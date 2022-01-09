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
        public AdminLoginForm(IAdminBusiness adminBusiness)
        {
            this.adminBusiness = adminBusiness;
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

            Thread thread = new Thread(() => OpenNewForm());
            thread.Start();
            this.Dispose();

        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void OpenNewForm()
        {
            Application.Run(new AdminPanelForm());
        }

    }
}
