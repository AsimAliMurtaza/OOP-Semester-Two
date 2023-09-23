using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3.UI
{
    internal class CatUI
    {
        public static Cat catInput()
        {
            Console.WriteLine("Enter cat name: ");
            string name = Console.ReadLine();

            Cat cat = new Cat(name);
            return cat;
        }
    }
}
