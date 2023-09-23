using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Products
    {
        public string name;
        public string category;
        public float price;
        public int quantity;
        public int minimumQuantity;
        public Products()
        {
            name = "";
            category = "grocery";
            price = 0.0F;
            quantity = 0;
            minimumQuantity = 10;
        }
        public Products(string n)
        {
            name = n;
        }
        public Products(string n, string c)
        {
            name = n;
            category = c;
        }
        public Products(string n, string c, float p)
        {
            name = n;
            category = c;
            price = p;
        }
        public Products(string n, string c, float p, int q)
        {
            name = n;
            category = c;
            price = p;
            quantity = q;
        }
        public Products(string n, string c, float p, int q, int minQuan)
        {
            name = n;
            category = c;
            price = p;
            quantity = q;
            minimumQuantity = minQuan;
        }
        public Products(Products prod)
        {
            name = prod.name;
            category = prod.category;
            price = prod.price;
            quantity = prod.quantity;
            minimumQuantity = prod.minimumQuantity;
        }
        public float calculateTax()
        {
            float tax;

            if (category == "grocery")
            {
                tax = price * (0.1F);
            }
            else if (category == "fruit")
            {
                tax = price * (0.05F);
            }
            else
            {
                tax = price * (0.15F);
            }
            return tax;
        }
    }
}
