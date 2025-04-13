using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
namespace FashionBoutiqueLogin
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["mydb1"].ConnectionString);


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
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();
                        string firstName = reader["FirstName"].ToString();
                        string ssn = reader["SSN"].ToString();

                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        lblMessage.Text = $"Welcome {firstName}!";
                        this.Hide();

                        Main mainForm = new Main(ssn, role);
                        mainForm.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                        lblMessage.Text = "Invalid Username or Password!";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = $"Error: {ex.Message}";
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

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor= ColorTranslator.FromHtml("#FF6B6B");
        }

        private void btnLogin_MouseHover_1(object sender, EventArgs e)
        {
            btnLogin.BackColor = ColorTranslator.FromHtml("#FF6B6B");
        }

        private void backgroundPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
    }
