using System;
using System.Drawing;
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
            backIconPictureBox.Click += backIconPictureBox_Click;
            ApplyButtonHoverEffects();
        }
        private void ApplyButtonHoverEffects()
        {
            foreach (Control control in backgroundpanel.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control childControl in panel.Controls)
                    {
                        if (childControl is Button button)
                        {
                            button.MouseEnter += (sender, e) => { button.BackColor = Color.LightPink; };
                            button.MouseLeave += (sender, e) => { button.BackColor = Color.White; };
                        }
                    }
                }
            }
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            NavigationManager.Push(this);
            this.Hide();
            Product product = new Product();
            product.ShowDialog();
            this.Show();
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            NavigationManager.Push(this); // Push the current form onto the stack
            this.Hide();
            Feedback feedback = new Feedback(currentEmployeeSSN);
            feedback.ShowDialog();
            this.Show();
        }

        private void employeebtn_Click_1(object sender, EventArgs e)
        {
            if (currentUserRole == "Admin")
            {
                NavigationManager.Push(this); // Push the current form onto the stack
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

        private void backIconPictureBox_Click(object sender, EventArgs e)
        {
            NavigationManager.ShowPreviousForm();
            this.Close();
        }

        private void purchasebtn_Click_1(object sender, EventArgs e)
        {
            NavigationManager.Push(this); // Push the current form onto the stack
            this.Hide();
            purchase purchase = new purchase();
            purchase.ShowDialog();
            this.Show();
        }
    }
}
