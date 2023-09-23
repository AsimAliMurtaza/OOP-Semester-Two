using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 1.0;
            Cylinder cylinder1 = new Cylinder();
            Cylinder cylinder2 = new Cylinder(radius);
            Cylinder cylinder3 = new Cylinder(radius, 12, "green");
            cylinder1.setHeight(5);
            cylinder2.setHeight(23);
            cylinder1.getVolume();

        }
    }
}
