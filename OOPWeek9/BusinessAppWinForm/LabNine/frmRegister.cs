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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }
        private void pbCustomerSignUp_Click(object sender, EventArgs e)
        {
            frmRegisterCustomer form = new frmRegisterCustomer();
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
