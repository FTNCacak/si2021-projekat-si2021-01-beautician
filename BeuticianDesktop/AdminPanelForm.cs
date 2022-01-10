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
namespace BeuticianDesktop
{
    public partial class AdminPanelForm : Form
    {

        private readonly ICategoryBusiness categoryBusiness;
        private readonly IManufacturerBusiness manufacturerBusiness;
        private readonly IProductBusiness productBusiness;

        private List<Product> products;
        private List<Category> categories;
        private List<Manufacturer> manufacturers;
        public AdminPanelForm(ICategoryBusiness categoryBusiness, IManufacturerBusiness manufacturerBusiness, IProductBusiness productBusiness, List<Product> products, List<Category> categories, List<Manufacturer> manufacturers)
        {
            this.products = products;
            this.categories = categories;
            this.manufacturers = manufacturers;
            this.categoryBusiness = categoryBusiness;
            this.manufacturerBusiness = manufacturerBusiness;
            this.productBusiness = productBusiness;
            InitializeComponent();
        }


        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            dataGridViewProduct.DataSource = products;
            dataGridViewProduct.Columns["ProductId"].Visible = false;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewCategoryProduct.DataSource = categories;
            dataGridViewCategoryProduct.Columns["CategoryId"].Visible = false;
            dataGridViewCategoryProduct.Columns["Description"].Visible = false;
            dataGridViewCategoryProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridViewManufacturerProduct.DataSource = manufacturers;
            dataGridViewManufacturerProduct.Columns["ManufacturerId"].Visible = false;
            dataGridViewManufacturerProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewCategory.DataSource = categories;
            dataGridViewCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewManufacturer.DataSource = manufacturers;
            dataGridViewManufacturer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

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

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectedProduct = dataGridViewProduct.SelectedRows[0].DataBoundItem as Product;

            labelProductID.Text = selectedProduct.ProductId.ToString();
            textBoxName.Text = selectedProduct.Name;
            textBoxPrice.Text = selectedProduct.Price.ToString();
            textBoxAmount.Text = selectedProduct.Amount.ToString();
            richTextBoxDescription.Text = selectedProduct.Description;


            textBoxCategoryProduct.Text = ConvertCategoryIdToName(selectedProduct.CategoryId);
            textBoxManufacturerProduct.Text = ConvertManufacturerIdToName(selectedProduct.ManufacturerId);

        }


        private void dataGridViewCategoryProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCategory = dataGridViewCategoryProduct.SelectedRows[0].DataBoundItem as Category;

            textBoxCategoryProduct.Text = ConvertCategoryIdToName(selectedCategory.CategoryId);
        }

        private void dataGridViewManufacturerProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedManufacturer = dataGridViewManufacturerProduct.SelectedRows[0].DataBoundItem as Manufacturer;

            textBoxManufacturerProduct.Text = ConvertManufacturerIdToName(selectedManufacturer.ManufacturerId);
        }

        private void dataGridViewManufacturer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedManufacturer = dataGridViewManufacturer.SelectedRows[0].DataBoundItem as Manufacturer;

            labelManufacturerId.Text = selectedManufacturer.ManufacturerId.ToString();
            textBoxManufacturer.Text = selectedManufacturer.Name;

        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedCategory = dataGridViewCategory.SelectedRows[0].DataBoundItem as Category;

            labelCategoryId.Text = selectedCategory.CategoryId.ToString();

            textBoxCategoryName.Text = selectedCategory.Name;

            richTextBoxCategoryDescription.Text = selectedCategory.Description;
        }


        public void RefreshData()
        {
            products = productBusiness.GetProducts();
            manufacturers = manufacturerBusiness.GetManufacturers();
            categories = categoryBusiness.GetCategories();


            dataGridViewProduct.DataSource = products;
            dataGridViewProduct.Columns["ProductId"].Visible = false;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewCategoryProduct.DataSource = categories;
            dataGridViewCategoryProduct.Columns["CategoryId"].Visible = false;
            dataGridViewCategoryProduct.Columns["Description"].Visible = false;
            dataGridViewCategoryProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            dataGridViewManufacturerProduct.DataSource = manufacturers;
            dataGridViewManufacturerProduct.Columns["ManufacturerId"].Visible = false;
            dataGridViewManufacturerProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewCategory.DataSource = categories;
            dataGridViewCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridViewManufacturer.DataSource = manufacturers;
            dataGridViewManufacturer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }


        private bool PriceFieldValidation(string Price)
        {
            decimal decimalNumber;

            bool result = decimal.TryParse(Price, out decimalNumber);

            return result;
        }

        private bool AmountFieldValidation(string Amount)
        {
            int intNumber;

            bool result = int.TryParse(Amount, out intNumber);

            return result;
        }

        private string ConvertCategoryIdToName(int CategoryId)
        {
            string result = "";
            foreach (var item in categories)
            {
                if (item.CategoryId == CategoryId)
                    result = item.Name;
            }

            return result;
        }

        private string ConvertManufacturerIdToName(int ManufacturerId)
        {
            string result = "";
            foreach (var item in manufacturers)
            {
                if (item.ManufacturerId == ManufacturerId)
                    result = item.Name;
            }

            return result;
        }


        private int ConvertCategoryNameToID(string CategoryName)
        {
            int ID = 1;
            foreach (var item in categories)
            {
                if (item.Name == CategoryName)
                    ID = item.CategoryId;
            }

            return ID;
        }


        private int ConvertManufacturerNameToID(string ManufacturerName)
        {
            int ID = 1;
            foreach (var item in manufacturers)
            {
                if (item.Name == ManufacturerName)
                    ID = item.ManufacturerId;
            }

            return ID;
        }

        private void buttonInsertProduct_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text;
            string Price = textBoxPrice.Text;
            string Amount = textBoxAmount.Text;
            string Description = richTextBoxDescription.Text;
            string CategoryId = textBoxCategoryProduct.Text;
            string ManufacturerId = textBoxManufacturerProduct.Text;

            if (Name == "" || Price == "" || Amount == "" || Description == "" || CategoryId == "" || ManufacturerId == "")
            {
                labelError.Text = "Sva polja moraju biti popunjena!";
                labelError.Visible = true;
                return;
            }

            if (!PriceFieldValidation(Price))
            {
                labelError.Text = "Pogrešan format polja za brojeve!";
                labelError.Visible = true;
                return;
            }

            if (!AmountFieldValidation(Amount))
            {
                labelError.Text = "Pogrešan format polja za brojeve!";
                labelError.Visible = true;
                return;
            }

            Product product = new Product(1, Name, Convert.ToDecimal(Price), Convert.ToInt32(Amount), Description, ConvertCategoryNameToID(CategoryId), ConvertManufacturerNameToID(ManufacturerId));

            productBusiness.InsertProduct(product);

            RefreshData();

            textBoxPrice.Text = "";
            textBoxAmount.Text = "";
            richTextBoxDescription.Text = "";
            textBoxCategoryProduct.Text = "";
            textBoxManufacturerProduct.Text = "";

            MessageBox.Show("Uspešno ste uneli proizvod.");

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {

            string ProductId = labelProductID.Text;
            string Name = textBoxName.Text;
            string Price = textBoxPrice.Text;
            string Amount = textBoxAmount.Text;
            string Description = richTextBoxDescription.Text;
            string CategoryId = textBoxCategoryProduct.Text;
            string ManufacturerId = textBoxManufacturerProduct.Text;

            if (ProductId == "")
            {
                labelError.Text = "Morate selektovati proizvod!";
                labelError.Visible = true;
                return;
            }

            if (Name == "" || Price == "" || Amount == "" || Description == "" || CategoryId == "" || ManufacturerId == "")
            {
                labelError.Text = "Sva polja moraju biti popunjena!";
                labelError.Visible = true;
                return;
            }

            if (!PriceFieldValidation(Price))
            {
                labelError.Text = "Pogrešan format polja za brojeve!";
                labelError.Visible = true;
                return;
            }

            if (!AmountFieldValidation(Amount))
            {
                labelError.Text = "Pogrešan format polja za brojeve!";
                labelError.Visible = true;
                return;
            }

            int productId = Convert.ToInt32(ProductId);
            Product product = new Product(productId, Name, Convert.ToDecimal(Price), Convert.ToInt32(Amount), Description, ConvertCategoryNameToID(CategoryId), ConvertManufacturerNameToID(ManufacturerId));

            productBusiness.UpdateProduct(product);

            RefreshData();

            labelProductID.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxAmount.Text = "";
            richTextBoxDescription.Text = "";
            textBoxCategoryProduct.Text = "";
            textBoxManufacturerProduct.Text = "";

            MessageBox.Show("Uspešno ste ažurirali proizvod.");
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            string ProductId = labelProductID.Text;


            if (ProductId == "")
            {
                labelError.Text = "Morate selektovati proizvod!";
                labelError.Visible = true;
                return;
            }



            int productId = Convert.ToInt32(ProductId);


            productBusiness.DeleteProduct(productId);

            RefreshData();

            labelProductID.Text = "";
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxAmount.Text = "";
            richTextBoxDescription.Text = "";
            textBoxCategoryProduct.Text = "";
            textBoxManufacturerProduct.Text = "";

            MessageBox.Show("Uspešno ste obrisali proizvod.");
        }

        private void buttonInsertManufacturer_Click(object sender, EventArgs e)
        {
            string ManufacturerName = textBoxManufacturer.Text;

            if (ManufacturerName == "")
            {
                labelErrorManufacturer.Text = "Polje mora biti popunjeno!";
                labelErrorManufacturer.Visible = true;
                return;
            }

            Manufacturer manufacturer = new Manufacturer(1, ManufacturerName);

            manufacturerBusiness.InsertManufacturer(manufacturer);
            RefreshData();
            MessageBox.Show("Uspešno ste uneli proizvodjača.");
            labelManufacturerId.Text = "";
            textBoxManufacturer.Text = "";
        }

        private void textBoxManufacturer_TextChanged(object sender, EventArgs e)
        {
            labelErrorManufacturer.Visible = false;
        }

        private void buttonUpdateManufacturer_Click(object sender, EventArgs e)
        {
            string ManufacturerName = textBoxManufacturer.Text;
            string ManufacturerId = labelManufacturerId.Text;

            if (ManufacturerId == "")
            {

                labelManufacturerId.Text = "Morate selektovati proizodjača!";
                labelManufacturerId.Visible = true;
                return;

            }
            if (ManufacturerName == "")
            {
                labelErrorManufacturer.Text = "Polje mora biti popunjeno!";
                labelErrorManufacturer.Visible = true;
                return;
            }

            int manufacturerId = Convert.ToInt32(ManufacturerId);
            Manufacturer manufacturer = new Manufacturer(manufacturerId, ManufacturerName);

            manufacturerBusiness.UpdateManufacturer(manufacturer);
            RefreshData();
            MessageBox.Show("Uspešno ste ažurirali proizvodjača.");
            labelManufacturerId.Text = "";
            textBoxManufacturer.Text = "";
        }

        private void buttonDeleteManufacturer_Click(object sender, EventArgs e)
        {
            string ManufacturerId = labelManufacturerId.Text;

            if (ManufacturerId == "")
            {

                labelManufacturerId.Text = "Morate selektovati proizodjača!";
                labelManufacturerId.Visible = true;
                return;

            }

            int manufacturerId = Convert.ToInt32(ManufacturerId);


            manufacturerBusiness.DeleteManufacturer(manufacturerId);
            RefreshData();
            MessageBox.Show("Uspešno ste obrisali proizvodjača.");
            labelManufacturerId.Text = "";
            textBoxManufacturer.Text = "";
        }

        private void buttonInsertCategory_Click(object sender, EventArgs e)
        {
            string CategoryName = textBoxCategoryName.Text;
            string CategoryDescription = richTextBoxCategoryDescription.Text;
            if (CategoryName == "" || CategoryDescription == "")
            {
                labelErrorCategory.Text = "Sva polja moraju biti popunjena!";
                labelErrorCategory.Visible = true;
                return;
            }

            Category category = new Category(1, CategoryName, CategoryDescription);

            categoryBusiness.InsertCategory(category);
            RefreshData();
            MessageBox.Show("Uspešno ste uneli kategoriju.");
            labelCategoryId.Text = "";
            textBoxCategoryName.Text = "";
            richTextBoxCategoryDescription.Text = "";
        }


        private void textBoxCategoryName_TextChanged(object sender, EventArgs e)
        {
            labelErrorManufacturer.Visible = false;
        }

        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            string CategoryName = textBoxCategoryName.Text;
            string CategoryDescription = richTextBoxCategoryDescription.Text;
            string CategoryId = labelCategoryId.Text;

            if (CategoryId == "")
            {
                labelErrorCategory.Text = "Morate selektovati kategoriju!";
                labelErrorCategory.Visible = true;
                return;
            }
            if (CategoryName == "" || CategoryDescription == "")
            {
                labelErrorCategory.Text = "Sva polja moraju biti popunjena!";
                labelErrorCategory.Visible = true;
                return;
            }

            int categoryId = Convert.ToInt32(CategoryId);
            Category category = new Category(categoryId, CategoryName, CategoryDescription);

            categoryBusiness.UpdateCategory(category);
            RefreshData();
            MessageBox.Show("Uspešno ste ažurirali kategoriju.");
            labelCategoryId.Text = "";
            textBoxCategoryName.Text = "";
            richTextBoxCategoryDescription.Text = "";
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
           
            string CategoryId = labelCategoryId.Text;

            if (CategoryId == "")
            {
                labelErrorCategory.Text = "Morate selektovati kategoriju!";
                labelErrorCategory.Visible = true;
                return;
            }
         

            int categoryId = Convert.ToInt32(CategoryId);
           

            categoryBusiness.DeleteCategory(categoryId);
            RefreshData();
            MessageBox.Show("Uspešno ste obrisali kategoriju.");
            labelCategoryId.Text = "";
            textBoxCategoryName.Text = "";
            richTextBoxCategoryDescription.Text = "";
        }
    }
}

