using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.UI
{
    internal class CircleUI
    {
        public static Circle getCircleInput()
        {
            Console.WriteLine("Enter radius of Circle: ");
            int rad = int.Parse(Console.ReadLine());
            Circle c = new Circle(rad);
            return c;
        }
    }
}
