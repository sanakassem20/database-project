using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Feedback : Form
    {
        private readonly string connectionString;
        private readonly string currentEmployeeSSN;

        // Constructor to accept the SSN
        public Feedback(string ssn)
        {
            InitializeComponent();

            // Initialize the connection string and SSN
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"]?.ConnectionString;
            currentEmployeeSSN = ssn;

            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string not found in App.config.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            try
            {
                // Load products into the ComboBox
                LoadProducts();

                // Load existing feedback records into the DataGridView
                LoadFeedbackRecords();

                // Populate the RateBox with ratings from 1 to 5
                PopulateRateBox();
            }
            catch (Exception ex)
            {
                HandleError("Error loading form.", ex);
            }
        }

        private void SubmitFeedbackButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (ProductComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(ProductComboBox.SelectedValue?.ToString()))
                {
                    MessageBox.Show("Please select a product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (RateBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a rating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int pid = Convert.ToInt32(ProductComboBox.SelectedValue);
                decimal rate = Convert.ToDecimal(RateBox.SelectedItem); // Get the selected rating
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
                        cmd.Parameters.AddWithValue("@EmployeeSSN", currentEmployeeSSN); // Use the passed SSN
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

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT DISTINCT PID, Name FROM Product";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No products found in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        ProductComboBox.DisplayMember = "Name";
                        ProductComboBox.ValueMember = "PID";
                        ProductComboBox.DataSource = dataTable;
                        ProductComboBox.SelectedIndex = -1;
                        ProductComboBox.Text = "Select Product";
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

        private void PopulateRateBox()
        {
            RateBox.Items.Clear();
            for (int i = 1; i <= 5; i++)
            {
                RateBox.Items.Add(i);
            }
            RateBox.SelectedIndex = -1;
            RateBox.Text = "Select Rating";
        }

        private void ClearFields()
        {
            ProductComboBox.SelectedIndex = -1;
            RateBox.SelectedIndex = -1;
            CommentTextBox.Clear();
        }

        private void HandleError(string message, Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            MessageBox.Show($"{message}\nDetails: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CommentLabel_Click(object sender, EventArgs e)
        {

        }
    }
}