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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxProduct.Location = new System.Drawing.Point(12, 162);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProduct.TabIndex = 0;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(12, 212);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(12, 262);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(200, 22);
            this.txtDiscount.TabIndex = 2;
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.Enabled = false;
            this.comboBoxEmployee.Location = new System.Drawing.Point(12, 312);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(200, 24);
            this.comboBoxEmployee.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(132, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(236, 162);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(177, 20);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            // 
            // lblBrand
            // 
            this.lblBrand.Location = new System.Drawing.Point(236, 192);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(177, 20);
            this.lblBrand.TabIndex = 7;
            this.lblBrand.Text = "Brand";
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(236, 222);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(177, 20);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "Size";
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(236, 252);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(177, 20);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            this.lblStock.Location = new System.Drawing.Point(236, 282);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(177, 20);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Product:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Discount %:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sold By:";
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            this.dataGridViewSales.ColumnHeadersHeight = 29;
            this.dataGridViewSales.Location = new System.Drawing.Point(438, 20);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.Size = new System.Drawing.Size(350, 488);
            this.dataGridViewSales.TabIndex = 15;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.backbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.backbtn.Location = new System.Drawing.Point(12, 20);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(102, 42);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // purchase
            // 
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.backbtn);
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
            this.Name = "purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.purchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button backbtn;
    }
}
