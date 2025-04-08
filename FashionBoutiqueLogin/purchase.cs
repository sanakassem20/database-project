using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Purchase : Form
    {
        SqlConnection con;

        public Purchase()
        {
            InitializeComponent();
            con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"].ToString());
        }

        private void Purchase_Load_1(object sender, EventArgs e)
        {
            LoadProductNames();
        }

        private void LoadProductNames()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Product", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxProduct.Items.Add(reader["Name"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE Name = @Name", con);
                cmd.Parameters.AddWithValue("@Name", comboBoxProduct.SelectedItem.ToString());
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBoxCategory.Text = reader["Category"].ToString();
                    textBoxBrand.Text = reader["Brand"].ToString();
                    textBoxSize.Text = reader["Size"].ToString();
                    textBoxStock.Text = reader["StockQuantity"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching product details: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem == null || numericUpDownQuantity.Value <= 0 || string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            try
            {
                con.Open();

                // Get PID from product name
                SqlCommand getPid = new SqlCommand("SELECT PID FROM Product WHERE Name = @Name", con);
                getPid.Parameters.AddWithValue("@Name", comboBoxProduct.SelectedItem.ToString());
                int pid = Convert.ToInt32(getPid.ExecuteScalar());

                // Insert Purchase record
                SqlCommand cmd = new SqlCommand("INSERT INTO Purchase (SaleID, PID, Quantity, PriceAtSale) VALUES (@SaleID, @PID, @Quantity, @Price)", con);
                cmd.Parameters.AddWithValue("@SaleID", textBoxSaleID.Text.Trim());
                cmd.Parameters.AddWithValue("@PID", pid);
                cmd.Parameters.AddWithValue("@Quantity", numericUpDownQuantity.Value);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(textBoxPrice.Text.Trim()));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Purchase recorded successfully!");

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting purchase: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            comboBoxProduct.SelectedIndex = -1;
            textBoxCategory.Clear();
            textBoxBrand.Clear();
            textBoxSize.Clear();
            textBoxStock.Clear();
            numericUpDownQuantity.Value = 1;
            textBoxPrice.Clear();
            dateTimePicker.Value = DateTime.Now;
            textBoxSaleID.Clear();
        }
    }
}
