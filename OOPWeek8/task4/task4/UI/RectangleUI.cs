using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.UI
{
    internal class RectangleUI
    {
        public static Rectangle getRectangleInput()
        {
            Console.WriteLine("Enter width of rect: ");
            int wid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of rect: ");
            int hei = int.Parse(Console.ReadLine());
            Rectangle r = new Rectangle(wid, hei);
            return r;
        }
    }
}
