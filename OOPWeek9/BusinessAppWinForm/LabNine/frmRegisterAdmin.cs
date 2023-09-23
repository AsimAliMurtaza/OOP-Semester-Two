using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessApp.BL;
using BusinessApp.DL;

namespace BusinessApp
{
    public partial class frmRegisterAdmin : Form
    {
        public frmRegisterAdmin()
        {
            InitializeComponent();
        }
        private void clearDataFromForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            frmAdminMenu form = new frmAdminMenu();
            this.Hide();
            form.Show();
        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            if (ValidationsDL.IsAlphanumeric(name) && !ValidationsDL.IsEmptySpace(name))
            {
                string password = txtPassword.Text;
                if (ValidationsDL.IsEightLength(password) && !ValidationsDL.IsEmptySpace(password))
                {
                    if (!UserDL.checkName(name))
                    {
                        AdminBL user = new AdminBL(name, password, "Admin");
                        UserDL.addUserToList(user);
                        UserDL.SaveUserDataIntoFile();
                        MessageBox.Show("User added successfully");
                        clearDataFromForm();
                        frmAdminMenu form = new frmAdminMenu();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.Focus();
                        erPRegisterName.SetError(this, "Name already exists");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Password (Should be minimum 8 characters and no empty spaces");
                }
            }
            else
            {
                MessageBox.Show("Enter Valid Username (no special characters and no empty spaces");
            }
        }
    }
}
