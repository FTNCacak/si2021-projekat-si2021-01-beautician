
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
            this.buttonProduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.panelManufacturer = new System.Windows.Forms.Panel();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCategory = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxManufacturer = new System.Windows.Forms.ListBox();
            this.buttonInsertProduct = new System.Windows.Forms.Button();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.buttonInsertCategory = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCategoryName = new System.Windows.Forms.TextBox();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxCategoryDescription = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelProduct.SuspendLayout();
            this.panelCategory.SuspendLayout();
            this.panelManufacturer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.White;
            this.panelProduct.Controls.Add(this.buttonDeleteProduct);
            this.panelProduct.Controls.Add(this.buttonUpdateProduct);
            this.panelProduct.Controls.Add(this.buttonInsertProduct);
            this.panelProduct.Controls.Add(this.label6);
            this.panelProduct.Controls.Add(this.listBoxManufacturer);
            this.panelProduct.Controls.Add(this.label4);
            this.panelProduct.Controls.Add(this.richTextBoxDescription);
            this.panelProduct.Controls.Add(this.label3);
            this.panelProduct.Controls.Add(this.textBoxAmount);
            this.panelProduct.Controls.Add(this.label2);
            this.panelProduct.Controls.Add(this.textBoxPrice);
            this.panelProduct.Controls.Add(this.label5);
            this.panelProduct.Controls.Add(this.listBoxCategory);
            this.panelProduct.Controls.Add(this.label1);
            this.panelProduct.Controls.Add(this.textBoxName);
            this.panelProduct.Controls.Add(this.dataGridViewProduct);
            this.panelProduct.Location = new System.Drawing.Point(64, 64);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(818, 585);
            this.panelProduct.TabIndex = 0;
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
            this.buttonProduct.Text = "Proizvod";
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
            this.button1.Text = "Katergorija";
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
            this.button2.Text = "Proizvodjač";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelCategory
            // 
            this.panelCategory.BackColor = System.Drawing.Color.White;
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
            this.panelCategory.Size = new System.Drawing.Size(818, 585);
            this.panelCategory.TabIndex = 1;
            // 
            // panelManufacturer
            // 
            this.panelManufacturer.BackColor = System.Drawing.Color.White;
            this.panelManufacturer.Controls.Add(this.button3);
            this.panelManufacturer.Controls.Add(this.button4);
            this.panelManufacturer.Controls.Add(this.button5);
            this.panelManufacturer.Controls.Add(this.label10);
            this.panelManufacturer.Controls.Add(this.textBox1);
            this.panelManufacturer.Controls.Add(this.dataGridView1);
            this.panelManufacturer.Location = new System.Drawing.Point(64, 64);
            this.panelManufacturer.Name = "panelManufacturer";
            this.panelManufacturer.Size = new System.Drawing.Size(818, 585);
            this.panelManufacturer.TabIndex = 2;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(47, 36);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(713, 269);
            this.dataGridViewProduct.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(88, 347);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(155, 29);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cena:";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(316, 347);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(155, 29);
            this.textBoxPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(488, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Količina:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(561, 347);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(155, 29);
            this.textBoxAmount.TabIndex = 5;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDescription.Location = new System.Drawing.Point(94, 408);
            this.richTextBoxDescription.MaxLength = 150;
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(219, 96);
            this.richTextBoxDescription.TabIndex = 7;
            this.richTextBoxDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opis:";
            // 
            // listBoxCategory
            // 
            this.listBoxCategory.FormattingEnabled = true;
            this.listBoxCategory.ItemHeight = 21;
            this.listBoxCategory.Location = new System.Drawing.Point(415, 408);
            this.listBoxCategory.Name = "listBoxCategory";
            this.listBoxCategory.Size = new System.Drawing.Size(120, 88);
            this.listBoxCategory.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kategorija:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Proizvodjač:";
            // 
            // listBoxManufacturer
            // 
            this.listBoxManufacturer.FormattingEnabled = true;
            this.listBoxManufacturer.ItemHeight = 21;
            this.listBoxManufacturer.Location = new System.Drawing.Point(640, 408);
            this.listBoxManufacturer.Name = "listBoxManufacturer";
            this.listBoxManufacturer.Size = new System.Drawing.Size(120, 88);
            this.listBoxManufacturer.TabIndex = 11;
            // 
            // buttonInsertProduct
            // 
            this.buttonInsertProduct.Location = new System.Drawing.Point(136, 527);
            this.buttonInsertProduct.Name = "buttonInsertProduct";
            this.buttonInsertProduct.Size = new System.Drawing.Size(159, 44);
            this.buttonInsertProduct.TabIndex = 13;
            this.buttonInsertProduct.Text = "Unesi";
            this.buttonInsertProduct.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.Location = new System.Drawing.Point(328, 527);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(159, 44);
            this.buttonUpdateProduct.TabIndex = 14;
            this.buttonUpdateProduct.Text = "Ažuriraj";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(517, 527);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(159, 44);
            this.buttonDeleteProduct.TabIndex = 15;
            this.buttonDeleteProduct.Text = "Obriši";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(568, 361);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(159, 44);
            this.buttonDeleteCategory.TabIndex = 23;
            this.buttonDeleteCategory.Text = "Obriši";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.Location = new System.Drawing.Point(568, 411);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(159, 44);
            this.buttonUpdateCategory.TabIndex = 22;
            this.buttonUpdateCategory.Text = "Ažuriraj";
            this.buttonUpdateCategory.UseVisualStyleBackColor = true;
            // 
            // buttonInsertCategory
            // 
            this.buttonInsertCategory.Location = new System.Drawing.Point(568, 311);
            this.buttonInsertCategory.Name = "buttonInsertCategory";
            this.buttonInsertCategory.Size = new System.Drawing.Size(159, 44);
            this.buttonInsertCategory.TabIndex = 21;
            this.buttonInsertCategory.Text = "Unesi";
            this.buttonInsertCategory.UseVisualStyleBackColor = true;
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
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(51, 122);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.Size = new System.Drawing.Size(460, 332);
            this.dataGridViewCategory.TabIndex = 16;
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
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 44);
            this.button3.TabIndex = 31;
            this.button3.Text = "Obriši";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(562, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 44);
            this.button4.TabIndex = 30;
            this.button4.Text = "Ažuriraj";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(561, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 44);
            this.button5.TabIndex = 29;
            this.button5.Text = "Unesi";
            this.button5.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(562, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 29);
            this.textBox1.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 269);
            this.dataGridView1.TabIndex = 26;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BeuticianDesktop.Properties.Resources.Timber;
            this.ClientSize = new System.Drawing.Size(942, 681);
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
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            this.panelManufacturer.ResumeLayout(false);
            this.panelManufacturer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ListBox listBoxManufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxCategory;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}