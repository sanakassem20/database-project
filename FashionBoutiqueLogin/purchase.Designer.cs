namespace FashionBoutiqueLogin
{
    partial class Purchase
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelSaleID = new System.Windows.Forms.Label();
            this.textBoxSaleID = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.SuspendLayout();

            // Title
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(180, 20);
            this.labelTitle.Text = "Purchase Entry Form";

            // Product
            this.labelProduct.Text = "Product:";
            this.labelProduct.Location = new System.Drawing.Point(40, 70);
            this.comboBoxProduct.Location = new System.Drawing.Point(150, 70);
            this.comboBoxProduct.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);

            // Category
            this.labelCategory.Text = "Category:";
            this.labelCategory.Location = new System.Drawing.Point(40, 110);
            this.textBoxCategory.Location = new System.Drawing.Point(150, 110);
            this.textBoxCategory.ReadOnly = true;

            // Brand
            this.labelBrand.Text = "Brand:";
            this.labelBrand.Location = new System.Drawing.Point(40, 150);
            this.textBoxBrand.Location = new System.Drawing.Point(150, 150);
            this.textBoxBrand.ReadOnly = true;

            // Size
            this.labelSize.Text = "Size:";
            this.labelSize.Location = new System.Drawing.Point(40, 190);
            this.textBoxSize.Location = new System.Drawing.Point(150, 190);
            this.textBoxSize.ReadOnly = true;

            // Stock
            this.labelStock.Text = "Stock Qty:";
            this.labelStock.Location = new System.Drawing.Point(40, 230);
            this.textBoxStock.Location = new System.Drawing.Point(150, 230);
            this.textBoxStock.ReadOnly = true;

            // Quantity
            this.labelQuantity.Text = "Quantity:";
            this.labelQuantity.Location = new System.Drawing.Point(40, 270);
            this.numericUpDownQuantity.Location = new System.Drawing.Point(150, 270);
            this.numericUpDownQuantity.Minimum = 1;
            this.numericUpDownQuantity.Maximum = 1000;

            // Price
            this.labelPrice.Text = "Price at Sale:";
            this.labelPrice.Location = new System.Drawing.Point(40, 310);
            this.textBoxPrice.Location = new System.Drawing.Point(150, 310);

            // Date
            this.labelDate.Text = "Date:";
            this.labelDate.Location = new System.Drawing.Point(40, 350);
            this.dateTimePicker.Location = new System.Drawing.Point(150, 350);

            // Sale ID
            this.labelSaleID.Text = "Sale ID:";
            this.labelSaleID.Location = new System.Drawing.Point(40, 390);
            this.textBoxSaleID.Location = new System.Drawing.Point(150, 390);

            // Buttons
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.Location = new System.Drawing.Point(100, 430);
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);

            this.buttonClear.Text = "Clear";
            this.buttonClear.Location = new System.Drawing.Point(220, 430);
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);

            // Add Controls
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelProduct); this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelCategory); this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.labelBrand); this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.labelSize); this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.labelStock); this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.labelQuantity); this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.labelPrice); this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.labelDate); this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelSaleID); this.Controls.Add(this.textBoxSaleID);
            this.Controls.Add(this.buttonSubmit); this.Controls.Add(this.buttonClear);

            // Form
            this.Text = "Purchase";
            this.ClientSize = new System.Drawing.Size(420, 500);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelSaleID;
        private System.Windows.Forms.TextBox textBoxSaleID;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
    }
}
