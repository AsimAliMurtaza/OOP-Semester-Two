using BusinessApp.BL;
using System;
using System.Collections;
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
    public partial class frmUpdateProductDetailsAdmin : Form
    {
        public frmUpdateProductDetailsAdmin()
        {
            InitializeComponent();
        }

        private void frmUpdateProductDetailsAdmin_Load(object sender, EventArgs e)
        {
            foreach (var i in ProductDL.GetProducts())
            {
                cmbList.Items.Add(i.GetProductName());
            }
        }

        private void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            ProductBL prod = ProductDL.GetProductByName(cmbList.Text);
            if(txtNewProductPrice.Text.All(char.IsDigit) && txtNewProductQuantity.Text.All(char.IsDigit))
            {
                prod.SetProductPrice(float.Parse(txtNewProductPrice.Text));
                prod.SetProductQuantity(int.Parse(txtNewProductQuantity.Text));
                ProductDL.SaveProductDataIntoFile();
                MessageBox.Show("Updated Successfully");
                frmAdminMenu form = new frmAdminMenu();
                this.Hide();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid details entered!");
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminMenu form = new frmAdminMenu();
            this.Hide();
            form.Show();
        }

        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductBL prod = ProductDL.GetProductByName(cmbList.Text);
            txtOldProductPrice.Text = prod.GetProductPrice().ToString();
            txtOldProductQuantity.Text = prod.GetProductQuantity().ToString();
        }
    }
}
