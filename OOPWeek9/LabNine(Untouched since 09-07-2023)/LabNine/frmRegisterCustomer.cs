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
    public partial class frmRegisterCustomer : Form
    {
        public frmRegisterCustomer()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;

            CustomerBL user = new CustomerBL(name, password, "Customer", phone, email);
            UserDL.addUserToList(user);
            UserDL.SaveUserDataIntoFile();
            MessageBox.Show("User added successfully");
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
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
        private void txtPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
        }
    }

}
