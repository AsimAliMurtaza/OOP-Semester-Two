using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessApp
{
    public partial class frmCustomerMenu : Form
    {
        public frmCustomerMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddToCartCustomer form = new frmAddToCartCustomer();
            form.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            frmDeleteFromCartCustomer form = new frmDeleteFromCartCustomer();
            form.Show();
            this.Hide();
        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            frmViewCartCustomer form = new frmViewCartCustomer();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            frmCheckoutCustomer form = new frmCheckoutCustomer();
            form.Show();
            this.Hide();
        }
    }
}
