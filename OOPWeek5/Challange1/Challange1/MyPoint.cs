using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange1
{
    internal class MyPoint
    {
        public int X;
        public int Y;

        public MyPoint()
        {
            X = 0;
            Y = 0;
        }
        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int getX()
        { return X; }
        public int getY() 
        { return Y; }
        public void setX(int x) 
        {  X = x; }
        public void setY(int y) 
        {  Y = y; }
        public void setXY(int x, int y)
        {  X = x; Y = y; }
        public double distanceWithZero()
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            return distance;
        }

        public double distanceWithCords(int a,  int b)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(a-X, 2)+Math.Pow(b-Y, 2));
            return distance;
        }
        public double distanceWithObject(MyPoint another)
        {
            double distance = 0;
            distance = Math.Sqrt(Math.Pow(another.X - X, 2) + Math.Pow(another.Y - Y, 2));
            return distance;
        }

    }
}
