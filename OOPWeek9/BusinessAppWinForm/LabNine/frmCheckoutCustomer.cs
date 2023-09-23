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
    public partial class frmCheckoutCustomer : Form
    {
        public frmCheckoutCustomer()
        {
            InitializeComponent();
        }

        private void frmCheckoutCustomer_Load(object sender, EventArgs e)
        {
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            if (customer is CustomerBL)
            {
                dgViewCart.DataSource = null;
                dgViewCart.DataSource = customer.GetProducts();
                dgViewCart.Refresh();
            }
            List<float> bill = customer.CalculateBill();
            txtTotalItems.Text = customer.GetProducts().Count.ToString();
            txtTotalPrice.Text = bill[0].ToString();
            txtTotalTax.Text = bill[1].ToString();
            txtTotalDiscount.Text = bill[2].ToString();
            txtTotalAmountDue.Text = bill[3].ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerMenu form = new frmCustomerMenu();
            form.Show();
            this.Hide();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            if (customer is CustomerBL)
            {
                CustomerDL.list.Add(customer);
                customer.ClearList();
            }
            MessageBox.Show("Order Paid Successfully");
            this.Hide();
            frmCustomerMenu form = new frmCustomerMenu();
            form.Show();
        }
    }
}
