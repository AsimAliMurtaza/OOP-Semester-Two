using ChallengeOne.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChallengeOne.UI
{
    internal class MenuItemUI
    {
        public static MenuItem AddAnItemToMenu()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter type: ");
            string type = Console.ReadLine();
            Console.Write("Enter price: ");
            float price = float.Parse(Console.ReadLine());
            if(price > 0)
            {
                MenuItem item = new MenuItem(name, type, price);
                return item;
            }
            else
            {
                Console.WriteLine("Cannot enter price = 0 or less!");
                Console.ReadKey();
            }
            return null;
        }
        public static void AddAnItemToMenuDisplay(bool isAdded)
        {
            if(isAdded)
            {
                Console.WriteLine("Item added Successfully!");
            }
            else
            {
                Console.WriteLine("Item could not be added!");
            }    
        }
        public static string takeOrdersInput()
        {
            Console.Write("Enter the name of the item to add to the order: ");
            string name = Console.ReadLine();
            return name;
        }

        public static void displayOrdersOutput(MenuItem item)
        {
            if(item != null)
            {
                Console.WriteLine("The "+item.Name+" is ready");
            }
            else
            {
                Console.WriteLine("All orders have been fulfilled!");
            }
        }
    }
}
