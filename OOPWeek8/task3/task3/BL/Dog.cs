using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.BL
{
    internal class Dog:Mammal
    {
        public Dog(string name) : base(name)
        {
            this.name = name;
        }
        public override void greet()
        {
            Console.WriteLine("woof");
        }
        public void greet(Dog another)
        {
            Console.WriteLine("wooooooooof");
        }
        public override string toString()
        {
            return "Name of kutta: " + name;
        }
    }
}
