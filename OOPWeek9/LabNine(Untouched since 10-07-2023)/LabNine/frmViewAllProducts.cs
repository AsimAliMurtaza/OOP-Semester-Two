using BusinessApp.BL;
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
    public partial class frmViewAllProducts : Form
    {
        public frmViewAllProducts()
        {
            InitializeComponent();
        }
        private void frmViewAllProducts_Load(object sender, EventArgs e)
        {
            dgViewAllProducts.DataSource = null;
            dgViewAllProducts.DataSource = ProductDL.GetProducts();
            dgViewAllProducts.Refresh();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminMenu form = new frmAdminMenu();
            form.Show();
            this.Hide();
        }
    }
}
