using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.UI
{
    internal class ShapeUI
    {
        static int count = 0;
        public static void showShapesAndAreas(List<Shape> shapes)
        {
            foreach (Shape s in shapes)
            {
                Console.WriteLine((count++ + 1) +". The shape is " + s.getShapeType() + " and the area is " + s.getArea());
            }
            Console.ReadKey();
        }
    }
}
