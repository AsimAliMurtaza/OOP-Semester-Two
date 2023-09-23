using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class Customer
    {
        public string Name;
        public List<Products> Products = new List<Products>();
        public List<int> prodQuantity = new List<int>();

        public Customer(string n)
        {
            Name = n;
        }

        public void AddProduct(Products p, int q) 
        {
            Products.Add(p);
            prodQuantity.Add(q);
        }
        public float CreateInvoice()
        {
            float result = 0F;
            for(int i = 0; i < Products.Count; i++) 
            {
                result = result + (Products[i].price + Products[i].calculateTax()) * Products[i].quantity;

            }
            Products.Clear();
            prodQuantity.Clear();
            return result;
        }
    }
}
