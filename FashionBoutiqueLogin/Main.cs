using System;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Main : Form
    {
        private readonly string currentEmployeeSSN;
        private readonly string currentUserRole; // Add role property

        // Constructor to accept both SSN and Role
        public Main(string ssn, string role)
        {
            InitializeComponent();
            currentEmployeeSSN = ssn; // Store the SSN
            currentUserRole = role;  // Store the role
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.ShowDialog();
            this.Show();
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            // Pass the SSN to the Feedback form
            this.Hide();
            Feedback feedback = new Feedback(currentEmployeeSSN);
            feedback.ShowDialog();
            this.Show();
        }

        private void Purchasebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchase purchase = new purchase();
            purchase.ShowDialog();
            this.Show();
        }



        private void employeebtn_Click_1(object sender, EventArgs e)
        {
            if (currentUserRole == "Admin")
            {
                this.Hide();
                Employee employee = new Employee();
                employee.ShowDialog();
                this.Show();
            }
            else
            {
                
                MessageBox.Show("You do not have permission to access the Employee page.");
            }
        }


    }
}
