using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    internal class Mammal:Animal
    {
        
        public Mammal(string name):base(name) { }
        public override void greet()
        {
            Console.WriteLine("World");
        }
        public override string toString()
        {
            return "Name: " + name;
        }
    }
}
