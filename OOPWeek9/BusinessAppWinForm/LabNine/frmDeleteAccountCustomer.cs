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
    public partial class frmDeleteAccountCustomer : Form
    {
        public frmDeleteAccountCustomer()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            if(txtDeleteAccount.Text == "Delete my account.")
            {
                if (customer is CustomerBL)
                {
                    UserDL.RemoveUserFromList(customer);
                    UserDL.SaveUserDataIntoFile();
                }
                MessageBox.Show("Account deleted successfully. Now you will be returned to the login screen.");
                frmLogin form = new frmLogin();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please type the sentence correctly");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmManageAccountCustomer form = new frmManageAccountCustomer();
            form.Show();
            this.Hide();
        }
    }
}
