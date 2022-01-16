
namespace BeuticianDesktop
{
    partial class AdminPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelProduct = new System.Windows.Forms.Panel();
            this.labelProductID = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.dataGridViewManufacturerProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewCategoryProduct = new System.Windows.Forms.DataGridView();
            this.textBoxManufacturerProduct = new System.Windows.Forms.TextBox();
            this.textBoxCategoryProduct = new System.Windows.Forms.TextBox();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.buttonInsertProduct = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.labelErrorCategory = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxCategoryDescription = new System.Windows.Forms.RichTextBox();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.buttonInsertCategory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.panelManufacturer = new System.Windows.Forms.Panel();
            this.labelErrorManufacturer = new System.Windows.Forms.Label();
            this.buttonDeleteManufacturer = new System.Windows.Forms.Button();
            this.buttonUpdateManufacturer = new System.Windows.Forms.Button();
            this.buttonInsertManufacturer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxManufacturer = new System.Windows.Forms.TextBox();
            this.dataGridViewManufacturer = new System.Windows.Forms.DataGridView();
            this.labelManufacturerId = new System.Windows.Forms.Label();
            this.labelCategoryId = new System.Windows.Forms.Label();
            this.panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturerProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoryProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.panelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.panelManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.White;
            this.panelProduct.Controls.Add(this.labelProductID);
            this.panelProduct.Controls.Add(this.labelError);
            this.panelProduct.Controls.Add(this.dataGridViewManufacturerProduct);
            this.panelProduct.Controls.Add(this.dataGridViewCategoryProduct);
            this.panelProduct.Controls.Add(this.textBoxManufacturerProduct);
            this.panelProduct.Controls.Add(this.textBoxCategoryProduct);
            this.panelProduct.Controls.Add(this.buttonDeleteProduct);
            this.panelProduct.Controls.Add(this.buttonUpdateProduct);
            this.panelProduct.Controls.Add(this.buttonInsertProduct);
            this.panelProduct.Controls.Add(this.label6);
            this.panelProduct.Controls.Add(this.label4);
            this.panelProduct.Controls.Add(this.richTextBoxDescription);
            this.panelProduct.Controls.Add(this.label3);
            this.panelProduct.Controls.Add(this.textBoxAmount);
            this.panelProduct.Controls.Add(this.label2);
            this.panelProduct.Controls.Add(this.textBoxPrice);
            this.panelProduct.Controls.Add(this.label5);
            this.panelProduct.Controls.Add(this.label1);
            this.panelProduct.Controls.Add(this.textBoxName);
            this.panelProduct.Controls.Add(this.dataGridViewProduct);
            this.panelProduct.Location = new System.Drawing.Point(64, 64);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(871, 628);
            this.panelProduct.TabIndex = 0;
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Location = new System.Drawing.Point(39, 513);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(0, 21);
            this.labelProductID.TabIndex = 21;
            this.labelProductID.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(108, 288);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(236, 21);
            this.labelError.TabIndex = 20;
            this.labelError.Text = "Sva polja moraju biti popunjena!";
            this.labelError.Visible = false;
            // 
            // dataGridViewManufacturerProduct
            // 
            this.dataGridViewManufacturerProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewManufacturerProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManufacturerProduct.GridColor = System.Drawing.Color.White;
            this.dataGridViewManufacturerProduct.Location = new System.Drawing.Point(605, 382);
            this.dataGridViewManufacturerProduct.Name = "dataGridViewManufacturerProduct";
            this.dataGridViewManufacturerProduct.RowHeadersWidth = 80;
            this.dataGridViewManufacturerProduct.Size = new System.Drawing.Size(215, 152);
            this.dataGridViewManufacturerProduct.TabIndex = 19;
            this.dataGridViewManufacturerProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManufacturerProduct_CellClick);
            // 
            // dataGridViewCategoryProduct
            // 
            this.dataGridViewCategoryProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCategoryProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoryProduct.GridColor = System.Drawing.Color.White;
            this.dataGridViewCategoryProduct.Location = new System.Drawing.Point(357, 382);
            this.dataGridViewCategoryProduct.Name = "dataGridViewCategoryProduct";
            this.dataGridViewCategoryProduct.RowHeadersWidth = 80;
            this.dataGridViewCategoryProduct.Size = new System.Drawing.Size(215, 152);
            this.dataGridViewCategoryProduct.TabIndex = 18;
            this.dataGridViewCategoryProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategoryProduct_CellClick);
            // 
            // textBoxManufacturerProduct
            // 
            this.textBoxManufacturerProduct.Enabled = false;
            this.textBoxManufacturerProduct.Location = new System.Drawing.Point(605, 354);
            this.textBoxManufacturerProduct.Name = "textBoxManufacturerProduct";
            this.textBoxManufacturerProduct.Size = new System.Drawing.Size(215, 29);
            this.textBoxManufacturerProduct.TabIndex = 17;
            this.textBoxManufacturerProduct.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxCategoryProduct
            // 
            this.textBoxCategoryProduct.Enabled = false;
            this.textBoxCategoryProduct.Location = new System.Drawing.Point(357, 354);
            this.textBoxCategoryProduct.Name = "textBoxCategoryProduct";
            this.textBoxCategoryProduct.Size = new System.Drawing.Size(215, 29);
            this.textBoxCategoryProduct.TabIndex = 16;
            this.textBoxCategoryProduct.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(607, 568);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(213, 44);
            this.buttonDeleteProduct.TabIndex = 15;
            this.buttonDeleteProduct.Text = "Obriši";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Location = new System.Drawing.Point(358, 568);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(214, 44);
            this.buttonUpdateProduct.TabIndex = 14;
            this.buttonUpdateProduct.Text = "Ažuriraj";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // buttonInsertProduct
            // 
            this.buttonInsertProduct.Location = new System.Drawing.Point(111, 568);
            this.buttonInsertProduct.Name = "buttonInsertProduct";
            this.buttonInsertProduct.Size = new System.Drawing.Size(217, 44);
            this.buttonInsertProduct.TabIndex = 13;
            this.buttonInsertProduct.Text = "Unesi";
            this.buttonInsertProduct.UseVisualStyleBackColor = true;
            this.buttonInsertProduct.Click += new System.EventHandler(this.buttonInsertProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Proizvodjač:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDescription.Location = new System.Drawing.Point(109, 438);
            this.richTextBoxDescription.MaxLength = 150;
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(219, 96);
            this.richTextBoxDescription.TabIndex = 7;
            this.richTextBoxDescription.Text = "";
            this.richTextBoxDescription.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Količina:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(112, 401);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(216, 29);
            this.textBoxAmount.TabIndex = 5;
            this.textBoxAmount.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cena:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(112, 364);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(216, 29);
            this.textBoxPrice.TabIndex = 3;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategorija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 328);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(216, 29);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(45, 27);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(775, 237);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellClick);
            // 
            // buttonProduct
            // 
            this.buttonProduct.BackColor = System.Drawing.Color.White;
            this.buttonProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Location = new System.Drawing.Point(64, 9);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(144, 55);
            this.buttonProduct.TabIndex = 1;
            this.buttonProduct.Text = "Proizvodi";
            this.buttonProduct.UseVisualStyleBackColor = false;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(207, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kategorije";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(350, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 55);
            this.button2.TabIndex = 3;
            this.button2.Text = "Proizvodjači";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.White;
            this.panelCategory.Controls.Add(this.labelCategoryId);
            this.panelCategory.Controls.Add(this.labelErrorCategory);
            this.panelCategory.Controls.Add(this.label7);
            this.panelCategory.Controls.Add(this.richTextBoxCategoryDescription);
            this.panelCategory.Controls.Add(this.buttonDeleteCategory);
            this.panelCategory.Controls.Add(this.buttonUpdateCategory);
            this.panelCategory.Controls.Add(this.buttonInsertCategory);
            this.panelCategory.Controls.Add(this.label8);
            this.panelCategory.Controls.Add(this.textBoxCategoryName);
            this.panelCategory.Controls.Add(this.dataGridViewCategory);
            this.panelCategory.Location = new System.Drawing.Point(64, 64);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(871, 628);
            this.panelCategory.TabIndex = 1;
            // 
            // labelErrorCategory
            // 
            this.labelErrorCategory.AutoSize = true;
            this.labelErrorCategory.Location = new System.Drawing.Point(517, 65);
            this.labelErrorCategory.Name = "labelErrorCategory";
            this.labelErrorCategory.Size = new System.Drawing.Size(236, 21);
            this.labelErrorCategory.TabIndex = 26;
            this.labelErrorCategory.Text = "Sva polja moraju biti popunjena!";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Opis:";
            // 
            // richTextBoxCategoryDescription
            // 
            this.richTextBoxCategoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxCategoryDescription.Location = new System.Drawing.Point(568, 190);
            this.richTextBoxCategoryDescription.MaxLength = 150;
            this.richTextBoxCategoryDescription.Name = "richTextBoxCategoryDescription";
            this.richTextBoxCategoryDescription.Size = new System.Drawing.Size(219, 96);
            this.richTextBoxCategoryDescription.TabIndex = 24;
            this.richTextBoxCategoryDescription.Text = "";
            this.richTextBoxCategoryDescription.TextChanged += new System.EventHandler(this.textBoxCategoryName_TextChanged);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(568, 410);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(219, 44);
            this.buttonDeleteCategory.TabIndex = 23;
            this.buttonDeleteCategory.Text = "Obriši";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.Location = new System.Drawing.Point(568, 355);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(219, 44);
            this.buttonUpdateCategory.TabIndex = 22;
            this.buttonUpdateCategory.Text = "Ažuriraj";
            this.buttonUpdateCategory.UseVisualStyleBackColor = true;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // buttonInsertCategory
            // 
            this.buttonInsertCategory.Location = new System.Drawing.Point(568, 304);
            this.buttonInsertCategory.Name = "buttonInsertCategory";
            this.buttonInsertCategory.Size = new System.Drawing.Size(219, 44);
            this.buttonInsertCategory.TabIndex = 21;
            this.buttonInsertCategory.Text = "Unesi";
            this.buttonInsertCategory.UseVisualStyleBackColor = true;
            this.buttonInsertCategory.Click += new System.EventHandler(this.buttonInsertCategory_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ime:";
            // 
            // textBoxCategoryName
            // 
            this.textBoxCategoryName.Location = new System.Drawing.Point(568, 127);
            this.textBoxCategoryName.Name = "textBoxCategoryName";
            this.textBoxCategoryName.Size = new System.Drawing.Size(219, 29);
            this.textBoxCategoryName.TabIndex = 17;
            this.textBoxCategoryName.TextChanged += new System.EventHandler(this.textBoxCategoryName_TextChanged);
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(51, 122);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 80;
            this.dataGridViewCategory.Size = new System.Drawing.Size(460, 332);
            this.dataGridViewCategory.TabIndex = 16;
            this.dataGridViewCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategory_CellClick);
            // 
            // panelManufacturer
            // 
            this.panelManufacturer.BackColor = System.Drawing.Color.White;
            this.panelManufacturer.Controls.Add(this.labelManufacturerId);
            this.panelManufacturer.Controls.Add(this.labelErrorManufacturer);
            this.panelManufacturer.Controls.Add(this.buttonDeleteManufacturer);
            this.panelManufacturer.Controls.Add(this.buttonUpdateManufacturer);
            this.panelManufacturer.Controls.Add(this.buttonInsertManufacturer);
            this.panelManufacturer.Controls.Add(this.label10);
            this.panelManufacturer.Controls.Add(this.textBoxManufacturer);
            this.panelManufacturer.Controls.Add(this.dataGridViewManufacturer);
            this.panelManufacturer.Location = new System.Drawing.Point(64, 64);
            this.panelManufacturer.Name = "panelManufacturer";
            this.panelManufacturer.Size = new System.Drawing.Size(871, 628);
            this.panelManufacturer.TabIndex = 2;
            // 
            // labelErrorManufacturer
            // 
            this.labelErrorManufacturer.AutoSize = true;
            this.labelErrorManufacturer.Location = new System.Drawing.Point(517, 65);
            this.labelErrorManufacturer.Name = "labelErrorManufacturer";
            this.labelErrorManufacturer.Size = new System.Drawing.Size(236, 21);
            this.labelErrorManufacturer.TabIndex = 32;
            this.labelErrorManufacturer.Text = "Sva polja moraju biti popunjena!";
            this.labelErrorManufacturer.Visible = false;
            // 
            // buttonDeleteManufacturer
            // 
            this.buttonDeleteManufacturer.Location = new System.Drawing.Point(561, 339);
            this.buttonDeleteManufacturer.Name = "buttonDeleteManufacturer";
            this.buttonDeleteManufacturer.Size = new System.Drawing.Size(192, 44);
            this.buttonDeleteManufacturer.TabIndex = 31;
            this.buttonDeleteManufacturer.Text = "Obriši";
            this.buttonDeleteManufacturer.UseVisualStyleBackColor = true;
            this.buttonDeleteManufacturer.Click += new System.EventHandler(this.buttonDeleteManufacturer_Click);
            // 
            // buttonUpdateManufacturer
            // 
            this.buttonUpdateManufacturer.Location = new System.Drawing.Point(562, 288);
            this.buttonUpdateManufacturer.Name = "buttonUpdateManufacturer";
            this.buttonUpdateManufacturer.Size = new System.Drawing.Size(192, 44);
            this.buttonUpdateManufacturer.TabIndex = 30;
            this.buttonUpdateManufacturer.Text = "Ažuriraj";
            this.buttonUpdateManufacturer.UseVisualStyleBackColor = true;
            this.buttonUpdateManufacturer.Click += new System.EventHandler(this.buttonUpdateManufacturer_Click);
            // 
            // buttonInsertManufacturer
            // 
            this.buttonInsertManufacturer.Location = new System.Drawing.Point(561, 238);
            this.buttonInsertManufacturer.Name = "buttonInsertManufacturer";
            this.buttonInsertManufacturer.Size = new System.Drawing.Size(192, 44);
            this.buttonInsertManufacturer.TabIndex = 29;
            this.buttonInsertManufacturer.Text = "Unesi";
            this.buttonInsertManufacturer.UseVisualStyleBackColor = true;
            this.buttonInsertManufacturer.Click += new System.EventHandler(this.buttonInsertManufacturer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(517, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 21);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ime:";
            // 
            // textBoxManufacturer
            // 
            this.textBoxManufacturer.Location = new System.Drawing.Point(562, 119);
            this.textBoxManufacturer.Name = "textBoxManufacturer";
            this.textBoxManufacturer.Size = new System.Drawing.Size(191, 29);
            this.textBoxManufacturer.TabIndex = 27;
            this.textBoxManufacturer.TextChanged += new System.EventHandler(this.textBoxManufacturer_TextChanged);
            // 
            // dataGridViewManufacturer
            // 
            this.dataGridViewManufacturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManufacturer.Location = new System.Drawing.Point(45, 114);
            this.dataGridViewManufacturer.MultiSelect = false;
            this.dataGridViewManufacturer.Name = "dataGridViewManufacturer";
            this.dataGridViewManufacturer.RowHeadersWidth = 80;
            this.dataGridViewManufacturer.Size = new System.Drawing.Size(460, 269);
            this.dataGridViewManufacturer.TabIndex = 26;
            this.dataGridViewManufacturer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewManufacturer_CellClick);
            // 
            // labelManufacturerId
            // 
            this.labelManufacturerId.AutoSize = true;
            this.labelManufacturerId.Location = new System.Drawing.Point(558, 190);
            this.labelManufacturerId.Name = "labelManufacturerId";
            this.labelManufacturerId.Size = new System.Drawing.Size(0, 21);
            this.labelManufacturerId.TabIndex = 33;
            this.labelManufacturerId.Visible = false;
            // 
            // labelCategoryId
            // 
            this.labelCategoryId.AutoSize = true;
            this.labelCategoryId.Location = new System.Drawing.Point(568, 485);
            this.labelCategoryId.Name = "labelCategoryId";
            this.labelCategoryId.Size = new System.Drawing.Size(0, 21);
            this.labelCategoryId.TabIndex = 27;
            this.labelCategoryId.Visible = false;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeuticianDesktop.Properties.Resources.Timber;
            this.ClientSize = new System.Drawing.Size(999, 730);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonProduct);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelManufacturer);
            this.Controls.Add(this.panelCategory);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beutician admin panel";
            this.Load += new System.EventHandler(this.AdminPanelForm_Load);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturerProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoryProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.panelManufacturer.ResumeLayout(false);
            this.panelManufacturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManufacturer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.Panel panelManufacturer;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonUpdateProduct;
        private System.Windows.Forms.Button buttonInsertProduct;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonUpdateCategory;
        private System.Windows.Forms.Button buttonInsertCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.DataGridView dataGridViewCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxCategoryDescription;
        private System.Windows.Forms.Button buttonDeleteManufacturer;
        private System.Windows.Forms.Button buttonUpdateManufacturer;
        private System.Windows.Forms.Button buttonInsertManufacturer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxManufacturer;
        private System.Windows.Forms.DataGridView dataGridViewManufacturer;
        private System.Windows.Forms.DataGridView dataGridViewManufacturerProduct;
        private System.Windows.Forms.DataGridView dataGridViewCategoryProduct;
        private System.Windows.Forms.TextBox textBoxManufacturerProduct;
        private System.Windows.Forms.TextBox textBoxCategoryProduct;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelErrorCategory;
        private System.Windows.Forms.Label labelErrorManufacturer;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.Label labelManufacturerId;
        private System.Windows.Forms.Label labelCategoryId;
    }
}