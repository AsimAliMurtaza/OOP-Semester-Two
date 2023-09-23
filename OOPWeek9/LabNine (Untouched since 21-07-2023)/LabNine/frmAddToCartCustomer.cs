using BusinessApp.BL;
using BusinessApp.DL;
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
    public partial class frmAddToCartCustomer : Form
    {
        public frmAddToCartCustomer()
        {
            InitializeComponent();
        }

        private void txtEnterQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            ProductBL prod = new ProductBL();
            prod = ProductDL.GetProductByName(ProductDL.GetProducts()[cmbList.SelectedIndex].GetProductName());
            prod.SetProductQuantity(int.Parse(txtEnterQuantity.Text));
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            if (customer is CustomerBL ) 
            {
                customer.AddProductToCart(prod);
            }
            
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerMenu form = new frmCustomerMenu();
            form.Show();
            this.Hide();
        }

        private void frmAddToCartCustomer_Load(object sender, EventArgs e)
        {
            foreach (var i in ProductDL.GetProducts())
            {
                cmbList.Items.Add(i.GetProductName());
            }
        }
    }
}
