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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void pbAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProductAdmin form = new frmAddProductAdmin();
            form.Show();
            this.Hide();
        }
        private void pbDeleteProduct_Click(object sender, EventArgs e)
        {
            frmDeleteProductAdmin form = new frmDeleteProductAdmin();
            form.Show();
            this.Hide();
        }

        private void pbUpdateProduct_Click(object sender, EventArgs e)
        {
            frmUpdateProductDetailsAdmin form = new frmUpdateProductDetailsAdmin();
            form.Show();
            this.Hide();
        }

        private void pbViewAllProducts_Click(object sender, EventArgs e)
        {
            frmViewAllProducts form = new frmViewAllProducts();
            form.Show();
            this.Hide();
        }

        private void pbViewUser_Click(object sender, EventArgs e)
        {
            frmViewUser form = new frmViewUser();
            form.Show();
            this.Hide();
        }

        private void pbAdminSignUp_Click(object sender, EventArgs e)
        {
            frmRegisterAdmin form = new frmRegisterAdmin();
            form.Show();
            this.Hide();
        }
    }
}
