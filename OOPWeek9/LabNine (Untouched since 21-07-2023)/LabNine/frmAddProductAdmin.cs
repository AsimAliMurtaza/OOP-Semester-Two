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
    public partial class frmAddProductAdmin : Form
    {
        public frmAddProductAdmin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float price = 0F;
            int quantity = 0;
            int id = int.Parse(txtProductID.Text);
            string productName = txtProductName.Text;
            string productPrice = txtProductPrice.Text;
            string productQuantity = txtProductQuantity.Text;
            if(productPrice.All(char.IsDigit) && productQuantity.All(char.IsDigit) && !txtProductID.Text.Contains(" ") && !txtProductName.Text.Contains(" ") && !txtProductPrice.Text.Contains(" ") && !txtProductQuantity.Text.Contains(" "))
            {
                price = float.Parse(productPrice);
                quantity = int.Parse(productQuantity);
                if (rbtnFruit.Checked)
                {
                    ProductBL prod = new ProductBL(id, productName, price, quantity, "fruit");
                    ProductDL.AddProduct(prod);
                    ProductDL.SaveProductDataIntoFile(prod);
                }
                else if (rbtnDairy.Checked)
                {
                    ProductBL prod = new ProductBL(id, productName, price, quantity, "dairy");
                    ProductDL.AddProduct(prod);
                    ProductDL.SaveProductDataIntoFile(prod);
                }
                else if (rbtnMeat.Checked)
                {
                    ProductBL prod = new ProductBL(id, productName, price, quantity, "meat");
                    ProductDL.AddProduct(prod);
                    ProductDL.SaveProductDataIntoFile(prod);
                }
                else if (rbtnOther.Checked)
                {
                    ProductBL prod = new ProductBL(id, productName, price, quantity, "other");
                    ProductDL.AddProduct(prod);
                    ProductDL.SaveProductDataIntoFile(prod);
                }
                else if (rbtnVegetable.Checked)
                {
                    ProductBL prod = new ProductBL(id, productName, price, quantity, "vegetable");
                    ProductDL.AddProduct(prod);
                    ProductDL.SaveProductDataIntoFile(prod);
                }
                MessageBox.Show("Product Added");
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdminMenu form = new frmAdminMenu();
            this.Hide();
            form.Show();
        }

        private void frmAddProductAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
