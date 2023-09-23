using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    internal class Cat:Mammal
    {
        public Cat(string name):base(name) 
        {
            this.name=name;
        }
        public override void greet()
        {
            Console.WriteLine("meowwww");
        }
        public override string toString()
        {
            return "Name of cat: " + name;
        }
    }
}
