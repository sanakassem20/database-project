using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FashionBoutiqueLogin
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"].ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"].ToString()))
                {
                    con.Open();

                    string query = @"SELECT Role, FirstName, LastName, SSN 
                             FROM Employee 
                             WHERE Username = @Username AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string role = reader["Role"].ToString();
                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            string fullName = firstName + " " + lastName;
                            string ssn = reader["SSN"].ToString();

                            lblMessage.ForeColor = System.Drawing.Color.Green;
                            lblMessage.Text = $"Welcome {fullName}!";

                            this.Hide();

                            // ✅ Pass both ssn and fullName to Main
                            Main mainForm = new Main(ssn, fullName);
                            mainForm.ShowDialog();

                            this.Show(); // return after closing Main
                        }
                        else
                        {
                            lblMessage.ForeColor = System.Drawing.Color.Red;
                            lblMessage.Text = "Invalid username or password.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Error: " + ex.Message;
            }
        }


        private void picxbox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: UI Design
        }

        private void backgroundPictureBox_Click(object sender, EventArgs e)
        {
            // Optional: UI Design
        }
    }
}
