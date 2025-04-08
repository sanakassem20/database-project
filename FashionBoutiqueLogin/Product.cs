using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Product : Form
    {
        private SqlConnection con;

        public Product()
        {
            InitializeComponent();
            // Initialize the connection string
            con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"].ToString());
        }

        private void Product_Load_1(object sender, EventArgs e)
        {
            // Load data into the DataGridView
            LoadProducts();

            // Populate ComboBoxes dynamically from the database
            LoadCategories();
            LoadBrands();

            // Populate SizeBox (if not already populated)
            SizeBox.Items.AddRange(new string[] { "S", "M", "L", "XL" });
        }

        private void LoadProducts()
        {
            try
            {
                // Open the connection
                con.Open();
                // Define the SQL query to fetch all products
                string query = "SELECT * FROM Product";
                // Create a DataAdapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                // Create a DataTable to hold the results
                DataTable dataTable = new DataTable();
                // Fill the DataTable with the query results
                adapter.Fill(dataTable);
                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void LoadCategories()
        {
            try
            {
                // Open the connection
                con.Open();
                // Define the SQL query to fetch unique categories
                string query = "SELECT DISTINCT Category FROM Product";
                // Create a SqlCommand to execute the query
                SqlCommand cmd = new SqlCommand(query, con);
                // Execute the query and read the results
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Add each category to the ComboBox
                    CategoryBox.Items.Add(reader["Category"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void LoadBrands()
        {
            try
            {
                // Open the connection
                con.Open();
                // Define the SQL query to fetch unique brands
                string query = "SELECT DISTINCT Brand FROM Product";
                // Create a SqlCommand to execute the query
                SqlCommand cmd = new SqlCommand(query, con);
                // Execute the query and read the results
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Add each brand to the ComboBox
                    BrandBox.Items.Add(reader["Brand"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading brands: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
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
                SizeBox.SelectedItem = selectedRow.Cells["Size"].Value.ToString();
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
            SizeBox.SelectedIndex = -1;
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
                string size = SizeBox.SelectedItem?.ToString();
                int stockQuantity = int.Parse(Quantity.Text);

                // Open the connection
                con.Open();
                // Define the SQL query to insert a new product
                string query = "INSERT INTO Product (Name, Category, Price, Brand, Size, StockQuantity) " +
                               "VALUES (@Name, @Category, @Price, @Brand, @Size, @StockQuantity)";
                // Create a SqlCommand to execute the query
                SqlCommand cmd = new SqlCommand(query, con);
                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Size", size);
                cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                // Execute the query
                cmd.ExecuteNonQuery();
                // Refresh the DataGridView
                LoadProducts();
                // Clear input fields
                ClearFields();
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void UpdateProduct_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the selected product's PID
                int pid = Convert.ToInt32(ID.Text);
                // Get updated values
                string name = Name.Text;
                string category = CategoryBox.SelectedItem?.ToString();
                decimal price = decimal.Parse(Price.Text);
                string brand = BrandBox.SelectedItem?.ToString();
                string size = SizeBox.SelectedItem?.ToString();
                int stockQuantity = int.Parse(Quantity.Text);

                // Open the connection
                con.Open();
                // Define the SQL query to update an existing product
                string query = "UPDATE Product SET Name = @Name, Category = @Category, Price = @Price, " +
                               "Brand = @Brand, Size = @Size, StockQuantity = @StockQuantity WHERE PID = @PID";
                // Create a SqlCommand to execute the query
                SqlCommand cmd = new SqlCommand(query, con);
                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Category", category);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Brand", brand);
                cmd.Parameters.AddWithValue("@Size", size);
                cmd.Parameters.AddWithValue("@StockQuantity", stockQuantity);
                cmd.Parameters.AddWithValue("@PID", pid);
                // Execute the query
                cmd.ExecuteNonQuery();
                // Refresh the DataGridView
                LoadProducts();
                MessageBox.Show("Product updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void DeleteProduct_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the selected product's PID
                int pid = Convert.ToInt32(ID.Text);
                // Open the connection
                con.Open();
                // Define the SQL query to delete a product
                string query = "DELETE FROM Product WHERE PID = @PID";
                // Create a SqlCommand to execute the query
                SqlCommand cmd = new SqlCommand(query, con);
                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@PID", pid);
                // Execute the query
                cmd.ExecuteNonQuery();
                // Refresh the DataGridView
                LoadProducts();
                MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string searchText = SearchText.Text.Trim();
                if (!string.IsNullOrEmpty(searchText))
                {
                    // Open the connection
                    con.Open();
                    // Define the SQL query to search for products
                    string query = "SELECT * FROM Product WHERE Name LIKE @SearchText OR Category LIKE @SearchText OR Brand LIKE @SearchText";
                    // Create a SqlCommand to execute the query
                    SqlCommand cmd = new SqlCommand(query, con);
                    // Add parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@SearchText", $"%{searchText}%");
                    // Create a DataAdapter to execute the query
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    // Create a DataTable to hold the results
                    DataTable dataTable = new DataTable();
                    // Fill the DataTable with the query results
                    adapter.Fill(dataTable);
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
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
            finally
            {
                // Close the connection
                con.Close();
            }
        }
    }
}