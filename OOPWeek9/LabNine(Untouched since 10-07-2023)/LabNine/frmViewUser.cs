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
    public partial class frmViewUser : Form
    {
        public frmViewUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminMenu form = new frmAdminMenu();
            form.Show();
            this.Hide();
        }

        private void frmViewUser_Load(object sender, EventArgs e)
        {
            dgViewUser.DataSource = null;
            dgViewUser.DataSource = getList();
            dgViewUser.Columns[0].HeaderText = "Name";
            dgViewUser.Columns[1].HeaderText = "Phone";
            dgViewUser.Columns[2].HeaderText = "Email";
            dgViewUser.Refresh();
        }
        private List<CustomerBL> getList()
        {
            List<CustomerBL> list = new List<CustomerBL>();
           foreach(var i in UserDL.getList())
            {
                if(i is CustomerBL)
                {
                    list.Add((CustomerBL)i);
                }
            }
            return list;
        }
    }
}
