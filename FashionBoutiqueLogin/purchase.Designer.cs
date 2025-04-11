using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    partial class purchase
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewSales;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label(); // Product
            this.label2 = new System.Windows.Forms.Label(); // Quantity
            this.label3 = new System.Windows.Forms.Label(); // Discount
            this.label4 = new System.Windows.Forms.Label(); // Employee
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();

            // Label - Product
            this.label1.AutoSize = true;
            this.label1.Text = "Product:";
            this.label1.Location = new System.Drawing.Point(40, 20);

            // ComboBox - Product
            this.comboBoxProduct.Location = new System.Drawing.Point(40, 40);
            this.comboBoxProduct.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.comboBoxProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);

            // Label - Quantity
            this.label2.AutoSize = true;
            this.label2.Text = "Quantity:";
            this.label2.Location = new System.Drawing.Point(40, 70);

            // TextBox - Quantity
            this.txtQuantity.Location = new System.Drawing.Point(40, 90);
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);

            // Label - Discount
            this.label3.AutoSize = true;
            this.label3.Text = "Discount %:";
            this.label3.Location = new System.Drawing.Point(40, 120);

            // TextBox - Discount
            this.txtDiscount.Location = new System.Drawing.Point(40, 140);
            this.txtDiscount.Size = new System.Drawing.Size(200, 22);

            // Label - Employee
            this.label4.AutoSize = true;
            this.label4.Text = "Sold By:";
            this.label4.Location = new System.Drawing.Point(40, 170);

            // ComboBox - Employee (disabled/read-only)
            this.comboBoxEmployee.Location = new System.Drawing.Point(40, 190);
            this.comboBoxEmployee.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEmployee.Enabled = false;

            // Save Button
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(40, 230);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Clear Button
            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(160, 230);
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Product Info Labels
            this.lblCategory.Location = new System.Drawing.Point(300, 40);
            this.lblCategory.Text = "Category:";
            this.lblCategory.Size = new System.Drawing.Size(250, 20);

            this.lblBrand.Location = new System.Drawing.Point(300, 70);
            this.lblBrand.Text = "Brand:";
            this.lblBrand.Size = new System.Drawing.Size(250, 20);

            this.lblSize.Location = new System.Drawing.Point(300, 100);
            this.lblSize.Text = "Size:";
            this.lblSize.Size = new System.Drawing.Size(250, 20);

            this.lblPrice.Location = new System.Drawing.Point(300, 130);
            this.lblPrice.Text = "Price:";
            this.lblPrice.Size = new System.Drawing.Size(250, 20);

            this.lblStock.Location = new System.Drawing.Point(300, 160);
            this.lblStock.Text = "Stock:";
            this.lblStock.Size = new System.Drawing.Size(250, 20);

            // DataGridView - Purchase History
            this.dataGridViewSales.Location = new System.Drawing.Point(40, 280);
            this.dataGridViewSales.Size = new System.Drawing.Size(700, 200);
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;

            // Add controls to form
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewSales);

            // Form settings
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Name = "purchase";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.purchase_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
