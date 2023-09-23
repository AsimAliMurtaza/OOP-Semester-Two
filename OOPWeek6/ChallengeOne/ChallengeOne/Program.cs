using ChallengeOne.BL;
using ChallengeOne.DL;
using ChallengeOne.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "items.txt";
            string choice = "";
            CoffeeShop coffeeShop = new CoffeeShop("Tesha's Coffee Shop");
            MenuList.readFromFile(path, coffeeShop);
            CoffeeShopUI.WelcomeMessage();

            while (choice != "9")
            {
                choice = DriverUI.DisplayMenu();

                if (choice == "1")
                {
                    Console.Clear();
                    MenuItem item = MenuItemUI.AddAnItemToMenu();
                    if (item != null)
                    {
                        bool isAdded = coffeeShop.AddMenuItem(item);
                        MenuItemUI.AddAnItemToMenuDisplay(isAdded);
                        Console.ReadKey();
                    }
                }
                if (choice == "2")
                {
                    Console.Clear();
                    string item = coffeeShop.CheapestItem();
                    CoffeeShopUI.CheapestItemDisplay(item);
                    Console.ReadKey();
                }
                if (choice == "3")
                {
                    Console.Clear();
                    MenuList.list = coffeeShop.DrinksOnly();
                    CoffeeShopUI.DrinksOnlyDisplay(MenuList.list);
                    Console.ReadKey();
                }
                if (choice == "4")
                {
                    Console.Clear();
                    MenuList.list = coffeeShop.FoodOnly();
                    CoffeeShopUI.FoodOnlyDisplay(MenuList.list);
                    Console.ReadKey();
                }
                if (choice == "5")
                {
                    Console.Clear();
                    string item = MenuItemUI.takeOrdersInput();
                    if (item != null)
                    {
                        bool isAdded = coffeeShop.AddOrder(item);
                        CoffeeShopUI.AddOrderDisplay(isAdded);
                        Console.ReadKey();
                    }
                }
                if (choice == "6")
                {
                    Console.Clear();
                    MenuItem item = coffeeShop.FulfillOrder();
                    MenuItemUI.displayOrdersOutput(item);
                    Console.ReadKey();
                }
                if (choice == "7")
                {
                    Console.Clear();
                    MenuList.list = coffeeShop.ListOrders();
                    CoffeeShopUI.ListOrderDisplay(MenuList.list);
                    Console.ReadKey();
                }
                if (choice == "8")
                {
                    Console.Clear();
                    float totalAmount = coffeeShop.DueAmount();
                    CoffeeShopUI.DueAmountDisplay(totalAmount);
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    }
}