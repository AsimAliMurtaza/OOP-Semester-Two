using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3
{
    internal class DogUI
    {
        public static Dog dogInput()
        {
            Console.WriteLine("Enter dog name: ");
            string name = Console.ReadLine();

            Dog dog = new Dog(name);
            return dog;
        }
    }
}
