using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeuticianDesktop
{
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            panelProduct.BringToFront();
            panelCategory.SendToBack();
            panelManufacturer.SendToBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelProduct.SendToBack();
            panelCategory.BringToFront();
            panelManufacturer.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelProduct.SendToBack();
            panelCategory.SendToBack();
            panelManufacturer.BringToFront();
        }
    }
}
