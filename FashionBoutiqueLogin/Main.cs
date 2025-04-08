using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionBoutiqueLogin
{
    public partial class Main: Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void navigationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void EmployeeBtn_Click(object sender, EventArgs e)
        {

            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product product = new Product();
            product.ShowDialog();
            this.Show();
        }

        private void purchasebtn_Click(object sender, EventArgs e)
        {
           
        }

        private void feedbackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback feedback = new Feedback();
            feedback.ShowDialog();
            this.Show();
        }
    }
}
