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


        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void pbAddToCart_Click(object sender, EventArgs e)
        {
            frmAddToCartCustomer form = new frmAddToCartCustomer();
            form.Show();
            this.Hide();
        }

        private void pbDeleteFromCart_Click(object sender, EventArgs e)
        {
            frmDeleteFromCartCustomer form = new frmDeleteFromCartCustomer();
            form.Show();
            this.Hide();
        }

        private void pbViewCart_Click(object sender, EventArgs e)
        {
            frmViewCartCustomer form = new frmViewCartCustomer();
            form.Show();
            this.Hide();
        }

        private void pbCheckout_Click(object sender, EventArgs e)
        {
            frmCheckoutCustomer form = new frmCheckoutCustomer();
            form.Show();
            this.Hide();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            frmManageAccountCustomer form = new frmManageAccountCustomer();
            form.Show();
                this.Hide();
        }
    }
}
