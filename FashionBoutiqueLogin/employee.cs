using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Employee : Form
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"].ConnectionString;

        public Employee()
        {
            InitializeComponent();
            backIconPictureBox.Click += backIconPictureBox_Click_1;
        }

        #region Event Handlers

        private void ClearFields()
        {
            SSNTXT.Clear();
            FIRSTNAMETXT.Clear();
            LASTNAMETXT.Clear();
            USERTXT.Clear();
            PASSTXT.Clear();
            SALARYTXT.Clear();
            ROLECOMBOBOX.SelectedIndex = -1;
        }


        // Add Employee Button Click
        private void addbtn_Click(object sender, EventArgs e)
        {
            string ssn = SSNTXT.Text.Trim();
            string firstName = FIRSTNAMETXT.Text.Trim();
            string lastName = LASTNAMETXT.Text.Trim();
            string username = USERTXT.Text.Trim();
            string salary = SALARYTXT.Text.Trim();
            string password = PASSTXT.Text.Trim();
            string role = ROLECOMBOBOX.SelectedItem?.ToString();

            // Validate input fields
            if (string.IsNullOrEmpty(ssn) || string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(salary) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        INSERT INTO Employee (SSN, FirstName, LastName, Username,Password, Salary, Role) 
                        VALUES (@SSN, @FirstName, @LastName, @Username,@Password, @Salary, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SSN", ssn);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Salary", decimal.Parse(salary));
                        cmd.Parameters.AddWithValue("@Role", role);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee added successfully!");
                            ClearFields();
                            LoadEmployees();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 2627) // Unique constraint violation
                {
                    MessageBox.Show("An employee with this SSN already exists.");
                }
                else
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Delete Employee Button Click - Ask for SSN
        private void deletebtn_Click(object sender, EventArgs e)
        {
            // Get the SSN from the SSNTXT text box
            string ssnToDelete = SSNTXT.Text.Trim();

            // Validate if the SSN input is not empty or null
            if (string.IsNullOrEmpty(ssnToDelete))
            {
                MessageBox.Show("Please enter a valid SSN in the SSN field.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Step 1: Check if the employee exists
                    string checkQuery = "SELECT * FROM Employee WHERE SSN = @SSN";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                    {
                        checkCmd.Parameters.AddWithValue("@SSN", ssnToDelete);

                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Close(); 

                             
                             
                                string deleteFeedbackQuery = "DELETE FROM Feedback WHERE EmployeeSSN = @SSN";
                                using (SqlCommand deleteFeedbackCmd = new SqlCommand(deleteFeedbackQuery, con))
                                {
                                    deleteFeedbackCmd.Parameters.AddWithValue("@SSN", ssnToDelete);
                                    deleteFeedbackCmd.ExecuteNonQuery();
                                }

                              
                                string deleteEmployeeQuery = "DELETE FROM Employee WHERE SSN = @SSN";
                                using (SqlCommand deleteEmployeeCmd = new SqlCommand(deleteEmployeeQuery, con))
                                {
                                    deleteEmployeeCmd.Parameters.AddWithValue("@SSN", ssnToDelete);

                                    int rowsAffected = deleteEmployeeCmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Employee and related records deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        LoadEmployees(); 
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to delete the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No employee found with the given SSN.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Form Load Event
        private void Employee_Load(object sender, EventArgs e)
        {
            ROLECOMBOBOX.Items.Add("Admin");
            ROLECOMBOBOX.Items.Add("Employee");

            LoadEmployees();
        }


        // Load Employees into DataGridView
        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Employee";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    DGV.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
        }

        #endregion

        private void updatebtn_Click(object sender, EventArgs e)
        {
            // Retrieve input values from textboxes and combobox
            string ssn = SSNTXT.Text.Trim();
            string firstName = FIRSTNAMETXT.Text.Trim();
            string lastName = LASTNAMETXT.Text.Trim();
            string username = USERTXT.Text.Trim();
            string salary = SALARYTXT.Text.Trim();
            string password = PASSTXT.Text.Trim(); // Retrieve password from textbox
            string role = ROLECOMBOBOX.SelectedItem?.ToString();

            // Validate input fields
            if (string.IsNullOrEmpty(ssn) || string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(salary) || string.IsNullOrEmpty(role) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // SQL query to update the Employee record (including Password)
                    string query = @"
                UPDATE Employee 
                SET FirstName = @FirstName, 
                    LastName = @LastName, 
                    Username = @Username, 
                    Password = @Password, 
                    Salary = @Salary, 
                    Role = @Role 
                WHERE SSN = @SSN";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@SSN", ssn);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); // Add password parameter
                        cmd.Parameters.AddWithValue("@Salary", decimal.Parse(salary));
                        cmd.Parameters.AddWithValue("@Role", role);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully!");
                            ClearFields();
                            LoadEmployees(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the given SSN.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
               
                if (sqlEx.Number == 2627) 
                {
                    MessageBox.Show("An employee with this SSN already exists.");
                }
                else
                {
                    MessageBox.Show($"SQL Error: {sqlEx.Message}");
                }
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void backIconPictureBox_Click_1(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        private void backgroundpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
