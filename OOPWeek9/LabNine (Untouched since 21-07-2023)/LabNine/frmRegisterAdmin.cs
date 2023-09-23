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

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            this.Hide();
            form.Show();
        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            if (!UserDL.checkName(name))
            {
                AdminBL user = new AdminBL(name, password, "Admin");
                UserDL.addUserToList(user);
                UserDL.SaveUserDataIntoFile();
                MessageBox.Show("User added successfully");
                clearDataFromForm();
                frmLogin form = new frmLogin();
                form.Show();
                this.Hide();
            }
            else
            {
                this.Focus();
                erPRegisterName.SetError(this, "Name already exists");
            }
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
