using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    internal class Animal
    {
        protected string name;
        public Animal(string name) { }
        public virtual void greet()
        {
            Console.WriteLine("Hello");
        }

        public virtual string toString()
        {
            return "Name: " + name;
        }
    }
}
