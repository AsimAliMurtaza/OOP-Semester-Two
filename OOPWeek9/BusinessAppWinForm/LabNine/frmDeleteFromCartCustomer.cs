using BusinessApp.BL;
using BusinessApp.DL;
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
    public partial class frmDeleteFromCartCustomer : Form
    {
        public frmDeleteFromCartCustomer()
        {
            InitializeComponent();
        }

        private void btnDeleteFromCart_Click(object sender, EventArgs e)
        {
            ProductBL prod = ProductDL.GetProductByName(ProductDL.GetProducts()[cmbList.SelectedIndex].GetProductName());
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            if (customer is CustomerBL)
            {
                customer.RemoveProductFromCart(prod);
                MessageBox.Show("Removed Successfully");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerMenu form = new frmCustomerMenu();
            form.Show();
            this.Hide();
        }

        private void frmDeleteFromCartCustomer_Load(object sender, EventArgs e)
        {
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            if (customer is CustomerBL)
            {
                foreach (var i in customer.GetProducts())
                {
                    cmbList.Items.Add(i.GetProductName());
                }
            }
        }
    }
}
