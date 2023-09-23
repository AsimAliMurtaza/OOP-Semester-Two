using BusinessApp.BL;
using BusinessApp.DL;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmChangePasswordCustomer : Form
    {
        public frmChangePasswordCustomer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmManageAccountCustomer form = new frmManageAccountCustomer();
            form.Show();
            this.Hide();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            string password = txtNewPassword.Text;
            if (ValidationsDL.IsEightLength(password) && !ValidationsDL.IsEmptySpace(password))
            {
                if (customer is CustomerBL)
                {
                    UserDL.changePasswordOfCustomer(password);
                    UserDL.SaveUserDataIntoFile();
                }
                MessageBox.Show("Password changed successfully! ");
                frmManageAccountCustomer form = new frmManageAccountCustomer();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Password (Should be minimum 8 characters and no empty spaces");
            }
        }

        private void frmChangePasswordCustomer_Load(object sender, EventArgs e)
        {
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            txtOldPassword.Text = customer.GetPassword();
        }
    }
}
