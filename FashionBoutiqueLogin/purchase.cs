using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class purchase : Form
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"].ToString();
        private readonly string loggedInSSN;
        private readonly string loggedInEmployeeName;

        public purchase(string employeeSSN, string employeeName)
        {
            InitializeComponent();
            loggedInSSN = employeeSSN;
            loggedInEmployeeName = employeeName;
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            LoadProducts();
            SetLoggedInEmployee();
            LoadSalesHistory();
        }

        private void LoadProducts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT PID, Name FROM Product", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxProduct.DataSource = dt;
                comboBoxProduct.DisplayMember = "Name";
                comboBoxProduct.ValueMember = "PID";

                if (dt.Rows.Count > 0)
                {
                    comboBoxProduct.SelectedIndex = 0;
                    comboBoxProduct_SelectedIndexChanged(comboBoxProduct, EventArgs.Empty);
                }
            }
        }

        private void SetLoggedInEmployee()
        {
            comboBoxEmployee.Items.Clear();
            comboBoxEmployee.Items.Add(loggedInEmployeeName);
            comboBoxEmployee.SelectedIndex = 0;
            comboBoxEmployee.Enabled = false;
        }

        private void LoadSalesHistory()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT p.PurchaseID, pr.Name AS Product, p.Quantity, 
                             p.TotalPrice, p.DiscountPercent, p.FinalPrice, 
                             e.FirstName + ' ' + e.LastName AS Employee
                      FROM Purchase p
                      JOIN Product pr ON p.PID = pr.PID
                      JOIN Employee e ON p.EmployeeSSN = e.SSN", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSales.DataSource = dt;
            }
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedValue != null && int.TryParse(comboBoxProduct.SelectedValue.ToString(), out int pid))
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE PID = @pid", con);
                        cmd.Parameters.AddWithValue("@pid", pid);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            lblCategory.Text = "Category: " + reader["Category"];
                            lblBrand.Text = "Brand: " + reader["Brand"];
                            lblSize.Text = "Size: " + reader["Size"];
                            lblPrice.Text = "Price: " + reader["Price"];
                            lblStock.Text = "Stock: " + reader["StockQuantity"];
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedValue == null || string.IsNullOrEmpty(txtQuantity.Text))
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }

            try
            {
                int pid = Convert.ToInt32(comboBoxProduct.SelectedValue);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                decimal price = decimal.Parse(lblPrice.Text.Replace("Price: ", ""));
                decimal discount = string.IsNullOrEmpty(txtDiscount.Text) ? 0 : Convert.ToDecimal(txtDiscount.Text);
                decimal total = quantity * price;
                decimal final = total * (1 - discount / 100);

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Update stock
                    SqlCommand stockCmd = new SqlCommand(
                        "UPDATE Product SET StockQuantity = StockQuantity - @qty WHERE PID = @pid AND StockQuantity >= @qty", con);
                    stockCmd.Parameters.AddWithValue("@qty", quantity);
                    stockCmd.Parameters.AddWithValue("@pid", pid);
                    if (stockCmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("Insufficient stock.");
                        return;
                    }

                    // Insert purchase
                    SqlCommand insert = new SqlCommand(
                        "INSERT INTO Purchase (PID, Quantity, TotalPrice, DiscountPercent, FinalPrice, EmployeeSSN) " +
                        "VALUES (@pid, @qty, @total, @discount, @final, @ssn)", con);
                    insert.Parameters.AddWithValue("@pid", pid);
                    insert.Parameters.AddWithValue("@qty", quantity);
                    insert.Parameters.AddWithValue("@total", total);
                    insert.Parameters.AddWithValue("@discount", discount);
                    insert.Parameters.AddWithValue("@final", final);
                    insert.Parameters.AddWithValue("@ssn", loggedInSSN);
                    insert.ExecuteNonQuery();
                }

                MessageBox.Show("Purchase saved successfully!");
                ClearForm();
                LoadSalesHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtQuantity.Clear();
            txtDiscount.Clear();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
