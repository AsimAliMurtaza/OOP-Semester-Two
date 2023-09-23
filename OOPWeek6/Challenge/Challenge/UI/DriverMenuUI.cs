using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.UI
{
    internal class DriverMenuUI
    {
        public static void Header()
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("**********UNIVERSITY ADMISSION MANAGEMENT SYSTEM*********");
            Console.WriteLine("*********************************************************");
            Console.WriteLine("---------------------------------------------------------");
        }
        public static int menuInterface()
        {
            Console.WriteLine("1. Add Student.");
            Console.WriteLine("2. Add Degree Program.");
            Console.WriteLine("3. Generate Merit.");
            Console.WriteLine("4. View Registered Users.");
            Console.WriteLine("5. View Students for a specific Program.");
            Console.WriteLine("6. Register subjects for a particular Student.");
            Console.WriteLine("7. Calculate fee for all registered Students.");
            Console.WriteLine("8. Exit.");
            Console.WriteLine("Enter Option: ");
            int choice = int.Parse(Console.ReadLine());

            return choice;
        }
    }
}
