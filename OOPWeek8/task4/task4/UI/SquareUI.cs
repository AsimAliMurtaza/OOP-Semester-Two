using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.UI
{
    internal class SquareUI
    {
        public static Square getSquareInput()
        {
            Console.WriteLine("Enter side of square: ");
            int side = int.Parse(Console.ReadLine());
            Square s = new Square(side);
            return s;
        }
    }
}
