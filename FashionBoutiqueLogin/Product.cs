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
        }

        private void Product_Load_1(object sender, EventArgs e)
        {
            // Load data into the DataGridView
            LoadProducts();
            // Populate ComboBoxes dynamically from the database
            LoadCategories();
            LoadBrands();

            // Attach the TextChanged event to the SearchText textbox
            SearchText.TextChanged += SearchText_TextChanged;
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
                ID.Text = selectedRow.Cells["PID"].Value.ToString();
                Name.Text = selectedRow.Cells["Name"].Value.ToString();
                CategoryBox.SelectedItem = selectedRow.Cells["Category"].Value.ToString();
                Price.Text = selectedRow.Cells["Price"].Value.ToString();
                BrandBox.SelectedItem = selectedRow.Cells["Brand"].Value.ToString();
                SizeBox.Text = selectedRow.Cells["Size"].Value.ToString();
                Quantity.Text = selectedRow.Cells["StockQuantity"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            ID.Clear();
            Name.Clear();
            Price.Clear();
            Quantity.Clear();
            CategoryBox.SelectedIndex = -1;
            BrandBox.SelectedIndex = -1;
            SizeBox.Clear();
        }

        private void AddProduct_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get user input
                string name = Name.Text;
                string category = CategoryBox.SelectedItem?.ToString();
                decimal price = decimal.Parse(Price.Text);
                string brand = BrandBox.SelectedItem?.ToString();
                string size = SizeBox.Text;
                int stockQuantity = int.Parse(Quantity.Text);

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
                // Validate PID
                if (string.IsNullOrEmpty(ID.Text))
                {
                    MessageBox.Show("Please enter a valid PID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int pid = Convert.ToInt32(ID.Text);

                // Variables to hold current product details
                string currentName = null, currentCategory = null, currentBrand = null, currentSize = null;
                decimal currentPrice = 0;
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
                            currentPrice = Convert.ToDecimal(reader["Price"]);
                            currentBrand = reader["Brand"].ToString();
                            currentSize = reader["Size"].ToString();
                            currentStockQuantity = Convert.ToInt32(reader["StockQuantity"]);
                        }
                    }
                }

                // Step 2: Use existing values if fields are empty
                string name = !string.IsNullOrEmpty(Name.Text) ? Name.Text : currentName;
                string category = CategoryBox.SelectedItem != null ? CategoryBox.SelectedItem.ToString() : currentCategory;
                decimal price = !string.IsNullOrEmpty(Price.Text) ? decimal.Parse(Price.Text) : currentPrice;
                string brand = BrandBox.SelectedItem != null ? BrandBox.SelectedItem.ToString() : currentBrand;
                string size = !string.IsNullOrEmpty(SizeBox.Text) ? SizeBox.Text : currentSize;
                int stockQuantity = !string.IsNullOrEmpty(Quantity.Text) ? int.Parse(Quantity.Text) : currentStockQuantity;

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
                // Get the selected product's PID
                int pid = Convert.ToInt32(ID.Text);

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

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = SearchText.Text.Trim();
                if (!string.IsNullOrEmpty(searchText))
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "SELECT * FROM Product WHERE Name LIKE @SearchText OR Category LIKE @SearchText OR Brand LIKE @SearchText";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@SearchText", $"%{searchText}%");
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

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}