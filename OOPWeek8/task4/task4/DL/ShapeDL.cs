using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task4.BL;

namespace task4.DL
{
    internal class ShapeDL
    {
        public static List<Shape> shapes = new List<Shape>();
        public static void addShapeToList(Shape shape)
        {
            shapes.Add(shape);
        }
        public static List<Shape> shapeList()
        {
            return shapes;
        }
    }
}
