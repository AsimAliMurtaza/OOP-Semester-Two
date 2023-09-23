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
    public partial class frmManageAccountCustomer : Form
    {
        public frmManageAccountCustomer()
        {
            InitializeComponent();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePasswordCustomer form = new frmChangePasswordCustomer();
            form.Show();
            this.Hide();
        }

        private void btnChangeEmail_Click(object sender, EventArgs e)
        {
            frmChangeEmailCustomer form = new frmChangeEmailCustomer();
            form.Show();
            this.Hide();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            frmDeleteAccountCustomer form = new frmDeleteAccountCustomer();
            form.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCustomerMenu frm = new frmCustomerMenu();
            frm.Show();
            this.Hide();
        }
    }
}
