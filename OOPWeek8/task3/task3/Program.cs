using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task3.BL;
using task3.DL;
using task3.UI;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = CatUI.catInput();
            Dog d1 = DogUI.dogInput();

            AnimalDL.addToList(c1);
            AnimalDL.addToList(d1);
            
            AnimalUI.showAnimal(AnimalDL.getList());
            d1.greet(d1);


        }
    }
}
