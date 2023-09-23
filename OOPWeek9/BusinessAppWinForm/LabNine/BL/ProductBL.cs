using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApp.BL
{
    internal class ProductBL
    {
        private int productID;
        private string productName;
        private float productPrice;
        private int productQuantity;
        private string productCategory;
        private float tax;

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public float ProductPrice { get => productPrice; set => productPrice = value; }
        public int ProductQuantity { get => productQuantity; set => productQuantity = value; }
        public string ProductCategory { get => productCategory; set => productCategory = value; }
        public float Tax { get => tax; set => tax = value; }

        public ProductBL()
        { }
        public ProductBL(int ID)
        {
            ProductID = ID;
        }
        public ProductBL(string name,int quantity, float price, string category)
        {
            this.ProductName = name;
            this.ProductQuantity = quantity;
            this.ProductPrice = price;
            this.ProductCategory = category;
        }
        public ProductBL(int ID, string n, float p, int q, string c) 
        {
            ProductID = ID;
            ProductName = n;
            ProductPrice = p;
            ProductQuantity = q;
            ProductCategory = c;
            if (c.ToLower()=="fruit")
            {
                this.Tax = 0.4F;
            }
            else if (c.ToLower() == "vegetable")
            {
                this.Tax = 0.1F;
            }
            else if (c.ToLower() == "dairy")
            {
                this.Tax = 0.3F;
            }
            else if (c.ToLower() == "meat")
            {
                this.Tax = 0.5F;
            }
            else if (c.ToLower() == "other")
            {
                this.Tax = 0.10F;
            }
        }

        public string GetProductName()
        { 
            return ProductName;
        }
        public void SetProductName(string name)
        {
            this.ProductName = name;
        }
        public float GetProductPrice() 
        {  
            return ProductPrice; 
        }
        public void SetProductPrice(float p)
        {  
            this.ProductPrice = p; 
        }
        public int GetProductQuantity() 
        {  
            return ProductQuantity;
        }
        public void SetProductQuantity(int q)
        { 
            ProductQuantity = q;
        }
        public int GetProductID()
        {  
            return ProductID; 
        }
        public void SetProductID(int id)
        {
            this.ProductID = id;
        }
        public string GetProductCategory()
        {
            return ProductCategory; 
        }
        public float getTax()
        {
            return this.Tax;
        }
        public string GetProductsDataString()
        {
            return $"{ProductCategory},{ProductName},{ProductQuantity},{ProductPrice},{ProductID}";
        }
        public string toString()
        {
            return "\t\t" + ProductID + "\t\t" + " " + ProductName + "\t\t" + " " + ProductQuantity + "\t\t\t" + " " + ProductPrice + "\t\t" + " " + ProductCategory;
        }
    }
}
