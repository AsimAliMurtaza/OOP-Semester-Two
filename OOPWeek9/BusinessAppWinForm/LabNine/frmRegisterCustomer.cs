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

        private void pbBack_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.Show();
            this.Hide();
        }

        private void pbSignUp_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text;
            if (ValidationsDL.IsAlphanumeric(name) && !ValidationsDL.IsEmptySpace(name))
            {
                string password = txtPassword.Text;
                if (ValidationsDL.IsEightLength(password) && !ValidationsDL.IsEmptySpace(password))
                {
                    string phone = txtPhone.Text;
                    if(phone.All(char.IsDigit))
                    {
                        string email = txtEmail.Text;
                        if(ValidationsDL.checkEmail(email) && ValidationsDL.checkComma(email))
                        {
                            CustomerBL user = new CustomerBL(name, password, "Customer", phone, email);
                            UserDL.addUserToList(user);
                            UserDL.SaveUserDataIntoFile();
                            MessageBox.Show("User added successfully");
                            frmLogin form = new frmLogin();
                            form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Enter Valid Email Address");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Phone Number");
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

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
        }
    }
}
