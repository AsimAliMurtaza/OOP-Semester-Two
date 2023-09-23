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
    public partial class frmChangeEmailCustomer : Form
    {
        public frmChangeEmailCustomer()
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
            string email = txtNewEmail.Text;
            if(ValidationsDL.checkEmail(email))
            {
                if (customer is CustomerBL)
                {
                    UserDL.changeEmailOfCustomer(email);
                    UserDL.SaveUserDataIntoFile();
                }
                MessageBox.Show("Email changed successfully! ");
                frmManageAccountCustomer form = new frmManageAccountCustomer();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Email Address Entered! ");
            }
        }

        private void frmChangeEmailCustomer_Load(object sender, EventArgs e)
        {
            UserBL customer = UserDL.GetUserFromList(Program.name, Program.password);
            txtOldEmail.Text = customer.GetEmail();
        }
    }
}
