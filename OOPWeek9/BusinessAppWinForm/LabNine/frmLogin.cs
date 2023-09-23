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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
        private void clearDataFromForm()
        {
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = (char)0;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
            frmRegister form = new frmRegister();
            form.Show();
            this.Hide();
        }

        private void pbSignIn_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            Program.name = name;
            string password = txtPassword.Text;
            Program.password = password;
            UserBL user = new UserBL(name, password);
            UserBL validUser = UserDL.SignIn(user);
            if (validUser != null)
            {
                if (validUser is AdminBL)
                {
                    MessageBox.Show("Welcome, Admin");
                    frmAdminMenu form = new frmAdminMenu();
                    form.Show();
                    this.Hide();
                }
                else if (validUser is CustomerBL)
                {
                    MessageBox.Show("Welcome, Customer");
                    frmCustomerMenu form = new frmCustomerMenu();
                    form.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("User not Valid");
            clearDataFromForm();

        }
    }
}
