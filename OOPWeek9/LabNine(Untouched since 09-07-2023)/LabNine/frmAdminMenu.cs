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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAdminHeader_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProductAdmin form = new frmAddProductAdmin();
            form.Show();
            this.Hide();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            frmDeleteProductAdmin form = new frmDeleteProductAdmin();
            form.Show();
            this.Hide();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            frmUpdateProductDetailsAdmin form = new frmUpdateProductDetailsAdmin();
            form.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void btnViewAllProducts_Click(object sender, EventArgs e)
        {
            frmViewAllProducts form = new frmViewAllProducts();
            form.Show();
            this.Hide();
        }

        private void btnAddProduct_MouseEnter(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAddProductAdmin form = new frmAddProductAdmin();
            form.Show();
            this.Hide();
        }

        

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
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
    }
}
