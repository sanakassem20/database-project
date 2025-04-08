using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Feedback : Form
    {
        private readonly string connectionString;

        public Feedback()
        {
            InitializeComponent();

            // Initialize the connection string from the configuration file
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"]?.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string not found in App.config.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Test the database connection
                TestDatabaseConnection();

                // Load products into the ComboBox
                LoadProducts();

                // Load existing feedback records into the DataGridView
                LoadFeedbackRecords();
            }
            catch (Exception ex)
            {
                HandleError("Error loading form.", ex);
            }
        }

        private void TestDatabaseConnection()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    MessageBox.Show("Database connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                HandleError("Database connection failed.", ex);
            }
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT PID, Name FROM Product";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Debugging: Check if the DataTable contains rows
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No products found in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Log the contents of the DataTable for debugging
                        foreach (DataRow row in dataTable.Rows)
                        {
                            Console.WriteLine($"PID: {row["PID"]}, Name: {row["Name"]}");
                        }

                        // Bind the DataTable to the ComboBox
                        ProductComboBox.DisplayMember = "Name"; // Display product name
                        ProductComboBox.ValueMember = "PID";    // Use PID as the value
                        ProductComboBox.DataSource = dataTable; // Set DataSource
                        ProductComboBox.Refresh();              // Force the ComboBox to update

                        // Debugging: Check the number of items in the ComboBox
                        Console.WriteLine($"Number of items in ComboBox: {ProductComboBox.Items.Count}");
                    }
                }
            }
            catch (Exception ex)
            {
                HandleError("Error loading products.", ex);
            }
        }

        private void LoadFeedbackRecords()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT F.ID, P.Name AS ProductName, F.EmployeeSSN, F.Rate, F.Comment, F.Date 
                        FROM Feedback F 
                        INNER JOIN Product P ON F.PID = P.PID";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        FeedbackDataGridView.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                HandleError("Error loading feedback records.", ex);
            }
        }

        private void SubmitFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (ProductComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(ProductComboBox.SelectedValue?.ToString()))
                {
                    MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(RateTextBox.Text, out decimal rate) || rate < 1 || rate > 5)
                {
                    MessageBox.Show("Please enter a valid rating between 1 and 5.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int pid = Convert.ToInt32(ProductComboBox.SelectedValue);
                string comment = CommentTextBox.Text.Trim(); // Trim whitespace
                DateTime date = DateTime.Now;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        INSERT INTO Feedback (PID, EmployeeSSN, Rate, Comment, Date) 
                        VALUES (@PID, @EmployeeSSN, @Rate, @Comment, @Date)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PID", pid);
                        cmd.Parameters.AddWithValue("@EmployeeSSN", GetCurrentEmployeeSSN()); // Replace with actual logic to get EmployeeSSN
                        cmd.Parameters.AddWithValue("@Rate", rate);
                        cmd.Parameters.AddWithValue("@Comment", comment);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.ExecuteNonQuery();
                    }
                }

                // Clear input fields after submission
                ClearFields();

                // Refresh the DataGridView to show the new feedback
                LoadFeedbackRecords();

                MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                HandleError("Error submitting feedback.", ex);
            }
        }

        private string GetCurrentEmployeeSSN()
        {
            // Replace this with logic to retrieve the current employee's SSN
            // For example, from session data or authentication system
            return "123456789"; // Example SSN
        }

        private void ClearFields()
        {
            ProductComboBox.SelectedIndex = -1;
            RateTextBox.Clear();
            CommentTextBox.Clear();
        }

        /// <summary>
        /// Handles errors by displaying a message box and logging the exception.
        /// </summary>
        /// <param name="message">The custom error message.</param>
        /// <param name="ex">The exception that occurred.</param>
        private void HandleError(string message, Exception ex)
        {
            // Log the exception details (you can use a logging framework like NLog or Serilog here)
            Console.WriteLine($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");

            // Show a user-friendly error message
            MessageBox.Show($"{message}\nDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}