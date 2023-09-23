using BlackJack.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.UI
{
    static class DriverUI
    {
        public static void playerHand()
        {
            Console.WriteLine("Player's Hand:");
        }
        public static void dealerHand()
        {
            Console.WriteLine("Dealer's Hand:");
        }
        public static string hitOrStand()
        {
            Console.Write("Do you want to hit or stand? (h/s): ");
            return Console.ReadLine();
        }
        public static void dealerWin()
        {
            Console.WriteLine("Dealer wins!");
        }
        public static void playerWin()
        {
            Console.WriteLine("Player wins!");
        }
        public static void Tie()
        {
            Console.WriteLine("It's a tie!");
        }
        public static void playerHandValue(int value)
        {
            Console.WriteLine("Player's Hand Value: " + value);
        }
        public static void dealerHandValue(int value)
        {
            Console.WriteLine("Dealer's Hand Value: " + value);
        }
        public static void dealerHit()
        {
            Console.WriteLine("Dealer hits.");
            Console.WriteLine("Dealer's Hand:");
        }
    }
}
