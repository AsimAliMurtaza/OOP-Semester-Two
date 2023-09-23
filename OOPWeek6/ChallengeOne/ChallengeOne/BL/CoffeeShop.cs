using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.BL
{
    internal class CoffeeShop
    {
        public string Name;
        public List<MenuItem> Menu = new List<MenuItem>();
        public List<MenuItem> Orders = new List<MenuItem>();

        public CoffeeShop(string name)
        {
            Name = name;
            Menu = new List<MenuItem>();
            Orders = new List<MenuItem>();
        }

        public bool AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
            return true;
        }
        public bool AddOrder(string name)
        {
            foreach(var item in Menu)
            {
                if(name ==  item.Name)
                {
                    Orders.Add(item);
                    return true;
                }
            }
            return false;
        }
        public MenuItem FulfillOrder()
        {
            if (Orders.Count > 0)
            {
                MenuItem item = Orders[0];
                Orders.RemoveAt(0);
                return item;
            }
            return null;
        }
        public List<MenuItem> ListOrders()
        {
            if (Orders.Count > 0)
            {
                return Orders;
            }
            else
            {
                return null;
            }
        }
        public float DueAmount()
        {
            float totalAmount = 0;

            foreach (var itemName in Orders)
            {
                foreach(var item in Menu)
                {
                    if(itemName.Name==item.Name)
                    {
                        totalAmount += item.Price;
                    }
                }
            }
            return totalAmount;
        }
        public string CheapestItem()
        {
            if (Menu.Count > 0)
            {
                MenuItem cheapestItem = Menu[0];
                foreach (MenuItem item in Menu)
                {
                    if (item.Price < cheapestItem.Price)
                    {
                        cheapestItem = item;
                    }
                }
                return cheapestItem.Name;
            }
            else
            {
                return null;
            }
        }
        public List<MenuItem> DrinksOnly()
        {
            List<MenuItem> drinks = new List<MenuItem>();
            foreach (MenuItem item in Menu)
            {
                if (item.Type == "drink")
                {
                    drinks.Add(item);
                }
            }
            return drinks;
        }
        public List<MenuItem> FoodOnly()
        {
            List<MenuItem> foodItems = new List<MenuItem>();
            foreach (MenuItem item in Menu)
            {
                if (item.Type == "food")
                {
                    foodItems.Add(item);
                }
            }
            return foodItems;
        }
    }
}
