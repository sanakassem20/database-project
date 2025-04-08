using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FashionBoutiqueLogin
{
    public partial class Form1 : Form
    {
        // Connection string
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Mydb"].ToString());

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            try
            {
                con.Open();
                string query = "SELECT Role, FirstName, SSN FROM Employee WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    string firstName = reader["FirstName"].ToString();
                    string ssn = reader["SSN"].ToString(); // Retrieve the SSN

                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    lblMessage.Text = $"Welcome {firstName}!";

                    if (role == "Admin")
                    {
                        this.Hide();

                        // Pass the SSN to the Main form
                        Main adminPanel = new Main(ssn);
                        adminPanel.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("You are not an admin. Access denied to admin panel.");
                    }
                }
                else
                {
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Text = "Invalid Username or Password!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Error: " + ex.Message;
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
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
    }
}