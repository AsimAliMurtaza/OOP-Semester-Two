using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4.BL
{
    internal class Rectangle:Shape
    {
        public int width; public int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public override double getArea()
        {
            return width * height;
        }
        public override string getShapeType()
        {
            return "Rectangle";
        }
    }
}
