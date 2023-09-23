using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3.UI
{
    internal class AnimalUI
    {
        public static void showAnimal(List<Animal> animals)
        {
            foreach(Animal animal in animals)
            {
                animal.greet();
                Console.WriteLine(animal.toString());
            }
        }
    }
}
