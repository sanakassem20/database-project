using System;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Main : Form
    {
        private readonly string currentEmployeeSSN;

        // Constructor to accept the SSN
        public Main(string ssn)
        {
            InitializeComponent();
            currentEmployeeSSN = ssn; // Store the SSN
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

        private void purchasebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Purchase purchase = new Purchase();
            purchase.ShowDialog();
            this.Show();
        }
    }
}