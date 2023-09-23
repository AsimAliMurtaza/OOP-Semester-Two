using BusinessApp.BL;
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
    public partial class frmDeleteProductAdmin : Form
    {
        public frmDeleteProductAdmin()
        {
            InitializeComponent();
        }

        private void frmDeleteProductAdmin_Load(object sender, EventArgs e)
        {
            foreach(var i in ProductDL.GetProducts())
            {
                cmbList.Items.Add(i.GetProductName());
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductDL.RemoveProduct(ProductDL.GetProductByName(ProductDL.GetProducts()[cmbList.SelectedIndex].GetProductName()));
            MessageBox.Show("Deleted Successfully");
            frmAdminMenu form = new frmAdminMenu();
            this.Hide();
            form.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAddProductAdmin form = new frmAddProductAdmin();
            form.Show();
            this.Hide();
        }
    }
}
