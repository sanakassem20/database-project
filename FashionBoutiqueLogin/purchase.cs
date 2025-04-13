using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class purchase : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["mydb1"].ToString());

        public purchase()
        {
            InitializeComponent();
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            // Load products
            SqlDataAdapter da = new SqlDataAdapter("SELECT PID, Name FROM Product", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxProduct.DisplayMember = "Name";
            comboBoxProduct.ValueMember = "PID";
            comboBoxProduct.DataSource = dt;

            // Load employees
            SqlDataAdapter daEmp = new SqlDataAdapter("SELECT SSN, FirstName + ' ' + LastName AS FullName FROM Employee", con);
            DataTable dtEmp = new DataTable();
            daEmp.Fill(dtEmp);
            comboBoxEmployee.DisplayMember = "FullName";
            comboBoxEmployee.ValueMember = "SSN";
            comboBoxEmployee.DataSource = dtEmp;
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProduct.SelectedValue == null || comboBoxProduct.SelectedIndex == -1)
                    return;

                // Fix: Ensure the value is not a DataRowView
                if (comboBoxProduct.SelectedValue is DataRowView)
                    return;

                int pid = Convert.ToInt32(comboBoxProduct.SelectedValue);

                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE PID = @pid", con);
                cmd.Parameters.AddWithValue("@pid", pid);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblCategory.Text = "Category: " + reader["Category"].ToString();
                    lblBrand.Text = "Brand: " + reader["Brand"].ToString();
                    lblSize.Text = "Size: " + reader["Size"].ToString();
                    lblPrice.Text = "Price: " + reader["Price"].ToString();
                    lblStock.Text = "Stock: " + reader["StockQuantity"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading product details: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedValue == null || txtQuantity.Text == "" || txtSaleID.Text == "" || comboBoxEmployee.SelectedValue == null)
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            try
            {
                int quantity = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(lblPrice.Text.Replace("Price: ", ""));
                decimal total = quantity * price;
                string saleID = txtSaleID.Text;
                int pid = Convert.ToInt32(comboBoxProduct.SelectedValue);
                string employeeSSN = comboBoxEmployee.SelectedValue.ToString();

                if (con.State == ConnectionState.Open)
                    con.Close();

                con.Open();

                // Check if Sale ID exists
                SqlCommand checkSale = new SqlCommand("SELECT COUNT(*) FROM Sale WHERE ID = @id", con);
                checkSale.Parameters.AddWithValue("@id", saleID);
                int count = (int)checkSale.ExecuteScalar();

                if (count == 0)
                {
                    SqlCommand insertSale = new SqlCommand("INSERT INTO Sale (ID, Date, EmployeeSSN, TotalAmount) VALUES (@id, @date, @ssn, @total)", con);
                    insertSale.Parameters.AddWithValue("@id", saleID);
                    insertSale.Parameters.AddWithValue("@date", DateTime.Now);
                    insertSale.Parameters.AddWithValue("@ssn", employeeSSN);
                    insertSale.Parameters.AddWithValue("@total", total);
                    insertSale.ExecuteNonQuery();
                }

                // Insert into Purchase
                SqlCommand insertPurchase = new SqlCommand("INSERT INTO Purchase (SaleID, PID, Quantity, PriceAtSale) VALUES (@saleID, @pid, @quantity, @price)", con);
                insertPurchase.Parameters.AddWithValue("@saleID", saleID);
                insertPurchase.Parameters.AddWithValue("@pid", pid);
                insertPurchase.Parameters.AddWithValue("@quantity", quantity);
                insertPurchase.Parameters.AddWithValue("@price", price);
                insertPurchase.ExecuteNonQuery();

                MessageBox.Show("Purchase saved successfully!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving purchase: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSaleID.Clear();
            txtQuantity.Clear();
            comboBoxProduct.SelectedIndex = -1;
            comboBoxEmployee.SelectedIndex = -1;
            lblCategory.Text = "Category:";
            lblBrand.Text = "Brand:";
            lblSize.Text = "Size:";
            lblPrice.Text = "Price:";
            lblStock.Text = "Stock:";
        }
    }
}
