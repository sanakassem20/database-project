namespace FashionBoutiqueLogin
{
    partial class purchase
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxEmployee; // Add comboBoxEmployee here

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox(); // Initialize comboBoxEmployee

            this.SuspendLayout();
            // 
            // label1 - Product
            this.label1.Text = "Select Product:";
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Size = new System.Drawing.Size(100, 20);
            // 
            // comboBoxProduct
            this.comboBoxProduct.Location = new System.Drawing.Point(40, 40);
            this.comboBoxProduct.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // label2 - Sale ID
            this.label2.Text = "Sale ID:";
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Size = new System.Drawing.Size(100, 20);
            // 
            // txtSaleID
            this.txtSaleID.Location = new System.Drawing.Point(40, 90);
            this.txtSaleID.Size = new System.Drawing.Size(200, 22);
            // 
            // label3 - Quantity
            this.label3.Text = "Quantity:";
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Size = new System.Drawing.Size(100, 20);
            // 
            // txtQuantity
            this.txtQuantity.Location = new System.Drawing.Point(40, 140);
            this.txtQuantity.Size = new System.Drawing.Size(200, 22);
            // 
            // Product Info Labels
            this.lblCategory.Location = new System.Drawing.Point(300, 40);
            this.lblCategory.Size = new System.Drawing.Size(250, 20);
            this.lblCategory.Text = "Category:";
            this.lblBrand.Location = new System.Drawing.Point(300, 70);
            this.lblBrand.Size = new System.Drawing.Size(250, 20);
            this.lblBrand.Text = "Brand:";
            this.lblSize.Location = new System.Drawing.Point(300, 100);
            this.lblSize.Size = new System.Drawing.Size(250, 20);
            this.lblSize.Text = "Size:";
            this.lblPrice.Location = new System.Drawing.Point(300, 130);
            this.lblPrice.Size = new System.Drawing.Size(250, 20);
            this.lblPrice.Text = "Price:";
            this.lblStock.Location = new System.Drawing.Point(300, 160);
            this.lblStock.Size = new System.Drawing.Size(250, 20);
            this.lblStock.Text = "Stock:";
            // 
            // btnSave
            this.btnSave.Text = "Save Purchase";
            this.btnSave.Location = new System.Drawing.Point(40, 220); // Adjusted to make space for the new combo box
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            this.btnClear.Text = "Clear";
            this.btnClear.Location = new System.Drawing.Point(170, 220); // Adjusted to make space for the new combo box
            this.btnClear.Size = new System.Drawing.Size(70, 30);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboBoxEmployee
            this.comboBoxEmployee.Location = new System.Drawing.Point(40, 190);
            this.comboBoxEmployee.Size = new System.Drawing.Size(200, 24);
            // Add the comboBoxEmployee to the form
            this.Controls.Add(this.comboBoxEmployee);
            // 
            // purchase
            this.ClientSize = new System.Drawing.Size(600, 270); // Adjusted the form size to include the new elements
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.txtSaleID);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Name = "purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.purchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
