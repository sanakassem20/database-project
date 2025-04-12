using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Employee : Form
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["mydb1"].ConnectionString;

        public Employee()
        {
            InitializeComponent();
        }

        #region Event Handlers

        // Add Employee Button Click
        private void addbtn_Click(object sender, EventArgs e)
        {
            string ssn = SSNTXT.Text.Trim();
            string firstName = FIRSTNAMETXT.Text.Trim();
            string lastName = LASTNAMETXT.Text.Trim();
            string username = USERTXT.Text.Trim();
            string salary = SALARYTXT.Text.Trim();
            string role = ROLECOMBOBOX.SelectedItem?.ToString();

            // Validate input fields
            if (string.IsNullOrEmpty(ssn) || string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(salary) || string.IsNullOrEmpty(role))
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
                        INSERT INTO Employee (SSN, FirstName, LastName, Username, Salary, Role) 
                        VALUES (@SSN, @FirstName, @LastName, @Username, @Salary, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SSN", ssn);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Username", username);
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
            // Prompt user to enter SSN of the employee to delete
            string ssnToDelete = Microsoft.VisualBasic.Interaction.InputBox("Enter SSN of the employee to delete:", "Delete Employee");
            if (string.IsNullOrEmpty(ssnToDelete))
            {
                MessageBox.Show("Please enter a valid SSN.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Check if the employee exists
                    string query = "SELECT * FROM Employee WHERE SSN = @SSN";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SSN", ssnToDelete);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows) // Employee exists
                            {
                                reader.Close(); // Close reader before running DELETE query

                                // Delete the employee
                                string deleteQuery = "DELETE FROM Employee WHERE SSN = @SSN";
                                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, con))
                                {
                                    deleteCmd.Parameters.AddWithValue("@SSN", ssnToDelete);

                                    int rowsAffected = deleteCmd.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Employee deleted successfully!");
                                        LoadEmployees(); // Refresh the employee list
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to delete employee.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No employee found with the given SSN.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        // Update Employee Button Click
        private void updateEmployeeBtn_Click(object sender, EventArgs e)
        {
            // Prompt user to enter SSN of the employee to update
            string ssnToUpdate = Microsoft.VisualBasic.Interaction.InputBox("Enter SSN of the employee to update:", "Update Employee");

            if (string.IsNullOrEmpty(ssnToUpdate))
            {
                MessageBox.Show("Please enter a valid SSN.");
                return;
            }

            // Fetch existing employee details
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Employee WHERE SSN = @SSN";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@SSN", ssnToUpdate);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows) // If employee found, show the info in input fields for updating
                        {
                            reader.Read();
                            SSNTXT.Text = reader["SSN"].ToString();
                            FIRSTNAMETXT.Text = reader["FirstName"].ToString();
                            LASTNAMETXT.Text = reader["LastName"].ToString();
                            USERTXT.Text = reader["Username"].ToString();
                            SALARYTXT.Text = reader["Salary"].ToString();
                            ROLECOMBOBOX.SelectedItem = reader["Role"].ToString();

                            // Ask user for confirmation to update
                            var confirmResult = MessageBox.Show("Do you want to update this employee?", "Confirm Update", MessageBoxButtons.YesNo);
                            if (confirmResult == DialogResult.Yes)
                            {
                                // After filling the fields, update the employee details
                                reader.Close(); // Close the reader before running UPDATE query
                                string updateQuery = @"
                            UPDATE Employee 
                            SET FirstName = @FirstName, LastName = @LastName, 
                                Username = @Username, Salary = @Salary, Role = @Role 
                            WHERE SSN = @SSN";
                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                                {
                                    updateCmd.Parameters.AddWithValue("@SSN", ssnToUpdate);
                                    updateCmd.Parameters.AddWithValue("@FirstName", FIRSTNAMETXT.Text);
                                    updateCmd.Parameters.AddWithValue("@LastName", LASTNAMETXT.Text);
                                    updateCmd.Parameters.AddWithValue("@Username", USERTXT.Text);
                                    updateCmd.Parameters.AddWithValue("@Salary", decimal.Parse(SALARYTXT.Text));
                                    updateCmd.Parameters.AddWithValue("@Role", ROLECOMBOBOX.SelectedItem.ToString());

                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Employee updated successfully!");
                                        LoadEmployees(); // Refresh the employee list
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to update employee.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No employee found with the given SSN.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


        // Load Employees Button Click
        private void loadbtn_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        // Form Load Event
        private void Employee_Load(object sender, EventArgs e)
        {
            ROLECOMBOBOX.Items.Add("Admin");
            ROLECOMBOBOX.Items.Add("Employee");

            LoadEmployees();
        }

        // Clear Input Fields
        private void ClearFields()
        {
            SSNTXT.Clear();
            FIRSTNAMETXT.Clear();
            LASTNAMETXT.Clear();
            USERTXT.Clear();
            SALARYTXT.Clear();
            ROLECOMBOBOX.SelectedIndex = -1;
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
    }
}
