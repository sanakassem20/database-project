using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Product : Form
    {
        private string connectionString;

        public Product()
        {
            InitializeComponent();
            // Initialize the connection string from the configuration file
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"].ToString();

            // Attach the Price_KeyPress event to restrict input
            Price.KeyPress += Price_KeyPress;
        }

        private void Product_Load_1(object sender, EventArgs e)
        {
            // Load data into the DataGridView
            LoadProducts();

            // Populate ComboBoxes dynamically from the database
            LoadCategories();
            LoadBrands();

            // Attach the TextChanged event to the SearchText textbox
            SearchText.TextChanged += SearchText_TextChanged_1;
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Product";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT DISTINCT Category FROM Product";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                CategoryBox.Items.Add(reader["Category"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBrands()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT DISTINCT Brand FROM Product";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                BrandBox.Items.Add(reader["Brand"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading brands: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                ID.Text = selectedRow.Cells["PID"].Value.ToString(); // Populate ID textbox
                Name.Text = selectedRow.Cells["Name"].Value.ToString();
                CategoryBox.SelectedItem = selectedRow.Cells["Category"].Value.ToString();
                Price.Text = selectedRow.Cells["Price"].Value.ToString();
                BrandBox.SelectedItem = selectedRow.Cells["Brand"].Value.ToString();
                SizeBox.Text = selectedRow.Cells["Size"].Value.ToString();
                Quantity.Value = Convert.ToDecimal(selectedRow.Cells["StockQuantity"].Value);
            }
        }

        private void ClearFields()
        {
            ID.Clear();
            Name.Clear();
            Price.Clear();
            CategoryBox.SelectedIndex = -1;
            BrandBox.SelectedIndex = -1;
            SizeBox.Clear();
            SearchText.Clear();
            Quantity.Value = 0;
        }

        private int GetPidForOperation()
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PID"].Value);
            }

            // Check if the ID field is filled
            if (!string.IsNullOrEmpty(ID.Text) && int.TryParse(ID.Text, out int pid))
            {
                return pid;
            }

            // If neither condition is met, return -1 to indicate an error
            return -1;
        }

        private void AddProduct_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate that all fields (except ID) are filled
                if (string.IsNullOrEmpty(Name.Text) ||
                    CategoryBox.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(Price.Text) ||
                    BrandBox.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(SizeBox.Text) ||
                    Quantity.Value == 0)
                {
                    MessageBox.Show("All fields must be filled except for ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Price
                if (!double.TryParse(Price.Text, out double price))
                {
                    MessageBox.Show("Please enter a valid price (numeric value).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get user input
                string name = Name.Text;
                string category = CategoryBox.SelectedItem?.ToString();
                string brand = BrandBox.SelectedItem?.ToString();
                string size = SizeBox.Text;
                int stockQuantity = (int)Quantity.Value;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Product (Name, Category, Price, Brand, Size, StockQuantity) " +
                                   "VALUES (@Name, @Category, @Price, @Brand, @Size, @StockQuantity)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Brand", brand);
                        cmd.Parameters.AddWithValue("@Size", size);
                        cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadProducts();
                ClearFields();
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateProduct_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the PID for the operation
                int pid = GetPidForOperation();
                if (pid == -1)
                {
                    MessageBox.Show("Please select a row or fill the ID field to update a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Variables to hold current product details
                string currentName = null, currentCategory = null, currentBrand = null, currentSize = null;
                double currentPrice = 0;
                int currentStockQuantity = 0;

                // Step 1: Retrieve the current product details
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string selectQuery = "SELECT * FROM Product WHERE PID = @PID";
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                    {
                        selectCmd.Parameters.AddWithValue("@PID", pid);
                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Product with the given PID does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Retrieve current values
                            currentName = reader["Name"].ToString();
                            currentCategory = reader["Category"].ToString();
                            currentPrice = Convert.ToDouble(reader["Price"]);
                            currentBrand = reader["Brand"].ToString();
                            currentSize = reader["Size"].ToString();
                            currentStockQuantity = Convert.ToInt32(reader["StockQuantity"]);
                        }
                    }
                }

                // Step 2: Use existing values if fields are empty
                string name = !string.IsNullOrEmpty(Name.Text) ? Name.Text : currentName;
                string category = CategoryBox.SelectedItem != null ? CategoryBox.SelectedItem.ToString() : currentCategory;
                string brand = BrandBox.SelectedItem != null ? BrandBox.SelectedItem.ToString() : currentBrand;
                string size = !string.IsNullOrEmpty(SizeBox.Text) ? SizeBox.Text : currentSize;

                // Validate Price
                double price;
                if (!double.TryParse(Price.Text, out price))
                {
                    price = currentPrice; // Use current price if input is invalid
                }

                int stockQuantity = (int)Quantity.Value;

                // Step 3: Update the product
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string updateQuery = "UPDATE Product SET Name = @Name, Category = @Category, Price = @Price, " +
                                         "Brand = @Brand, Size = @Size, StockQuantity = @StockQuantity WHERE PID = @PID";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                    {
                        updateCmd.Parameters.AddWithValue("@Name", name);
                        updateCmd.Parameters.AddWithValue("@Category", category);
                        updateCmd.Parameters.AddWithValue("@Price", price);
                        updateCmd.Parameters.AddWithValue("@Brand", brand);
                        updateCmd.Parameters.AddWithValue("@Size", size);
                        updateCmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                        updateCmd.Parameters.AddWithValue("@PID", pid);
                        updateCmd.ExecuteNonQuery();
                    }
                }

                // Refresh the DataGridView
                LoadProducts();
                ClearFields();
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteProduct_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the PID for the operation
                int pid = GetPidForOperation();
                if (pid == -1)
                {
                    MessageBox.Show("Please select a row or fill the ID field to delete a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Step 1: Delete related feedback records
                    string deleteFeedbackQuery = "DELETE FROM Feedback WHERE PID = @PID";
                    using (SqlCommand cmdFeedback = new SqlCommand(deleteFeedbackQuery, con))
                    {
                        cmdFeedback.Parameters.AddWithValue("@PID", pid);
                        cmdFeedback.ExecuteNonQuery();
                    }

                    // Step 2: Delete related purchase records
                    string deletePurchaseQuery = "DELETE FROM Purchase WHERE PID = @PID";
                    using (SqlCommand cmdPurchase = new SqlCommand(deletePurchaseQuery, con))
                    {
                        cmdPurchase.Parameters.AddWithValue("@PID", pid);
                        cmdPurchase.ExecuteNonQuery();
                    }

                    // Step 3: Delete the product
                    string deleteProductQuery = "DELETE FROM Product WHERE PID = @PID";
                    using (SqlCommand cmdProduct = new SqlCommand(deleteProductQuery, con))
                    {
                        cmdProduct.Parameters.AddWithValue("@PID", pid);
                        cmdProduct.ExecuteNonQuery();
                    }
                }

                LoadProducts();
                ClearFields();
                MessageBox.Show("Product, its feedback, and purchase records deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchText_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string searchText = SearchText.Text.Trim();
                if (!string.IsNullOrEmpty(searchText))
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "SELECT * FROM Product WHERE Name LIKE @SearchText";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@SearchText", $"{searchText}%");
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                dataGridView1.DataSource = dataTable;
                            }
                        }
                    }
                }
                else
                {
                    // Reload all products if search text is empty
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, decimal point, backspace, and negative sign
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.Handled = true; // Ignore invalid input
            }

            // Allow only one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }

            // Allow only one negative sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true;
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}