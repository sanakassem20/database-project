using System;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Main : Form
    {
        private readonly string currentEmployeeSSN;
        private readonly string currentEmployeeName;

        public Main(string ssn, string fullName)
        {
            InitializeComponent();
            currentEmployeeSSN = ssn;
            currentEmployeeName = fullName;
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
            this.Hide();
            Feedback feedback = new Feedback(currentEmployeeSSN);
            feedback.ShowDialog();
            this.Show();
        }

        private void purchasebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            purchase purchaseForm = new purchase(currentEmployeeSSN, currentEmployeeName);
            purchaseForm.ShowDialog();
            this.Show();
        }

        private void backgroundpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employeebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee employee = new Employee();
            employee.ShowDialog();
            this.Show();
        }
    }
}
