using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3.DL
{
    internal class AnimalDL
    {
        public static List<Animal> Animals = new List<Animal>();

        public static List<Animal> getList()
        {
            return Animals;
        }

        public static void addToList(Animal ani)
        {
            Animals.Add(ani);
        }

    }
}
