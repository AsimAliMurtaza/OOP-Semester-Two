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
    public partial class frmViewCartCustomer : Form
    {
        public frmViewCartCustomer()
        {
            InitializeComponent();
        }

        private void frmViewCartCustomer_Load(object sender, EventArgs e)
        {
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            if (customer is CustomerBL)
            {
                dgViewCart.DataSource = null;
                dgViewCart.DataSource = customer.GetProducts();
                dgViewCart.Refresh();
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerMenu form = new frmCustomerMenu();
            form.Show();
            this.Hide();
        }
    }
}
