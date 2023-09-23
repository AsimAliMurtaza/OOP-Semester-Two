using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Circle
    {
        protected double radius;
        protected string color;

        public Circle()
        {

        }
        public Circle(double radius)
        { this.radius = radius; }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        { this.radius = radius; }
        public string getColor()
        {
            return color;
        }
        public void setColor(string color)
        { this.color = color; }
        public double getArea()
        {
            return ((3.14) * radius / 2);
        }
        public string toString()
        {
            return null;
        }
    }
}
