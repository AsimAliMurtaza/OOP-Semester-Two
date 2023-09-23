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
            ProductDL.SaveProductDataIntoFile();
            MessageBox.Show("Deleted Successfully");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminMenu form = new frmAdminMenu();
            form.Show();
            this.Hide();
        }
    }
}
