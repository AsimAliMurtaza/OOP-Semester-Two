using ChallengeOne.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.UI
{
    internal class CoffeeShopUI
    {
        public static void CheapestItemDisplay(string item)
        {
            if (item != null)
            {
                Console.WriteLine("Cheapest item on the menu is {0}", item);
            }
            else
            {
                Console.WriteLine("No item available right now");
            }
        }
        public static void FoodOnlyDisplay(List<MenuItem> list)
        {
            Console.WriteLine("Name of items");
            foreach (MenuItem item in list)
            {
                Console.WriteLine(item.Name + "\t" + item.Price);
            }
        }
        public static void DrinksOnlyDisplay(List<MenuItem> list)
        {
            Console.WriteLine("Name of items");
            foreach (var item in list)
            {
                Console.WriteLine(item.Name +"\t" + item.Price);
            }
        }
        public static void AddOrderDisplay(bool isAdded)
        {
            if (isAdded)
            {
                Console.WriteLine("Item added to the order successfully!");
            }
            else
            {
                Console.WriteLine("Item does not exist in the menu");
            }
        }
        public static void ListOrderDisplay(List<MenuItem> list)
        {
            if(list!=null)
            {
                Console.WriteLine("Name of items in Order List");
                foreach (MenuItem item in list)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else { Console.WriteLine("No orders in the list"); }
        }
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Tesha's Coffee Shop");
        }
        public static void DueAmountDisplay(float amount)
        {
            if(amount > 0)
            {
                Console.WriteLine("Total Amount Payable: {0}", amount);
            }
            else
            {
                Console.WriteLine("No amount payable! Order something first");
            }
        }
    }
}
