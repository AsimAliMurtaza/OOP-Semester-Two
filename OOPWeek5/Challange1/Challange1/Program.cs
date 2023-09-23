using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Challange1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            MyLine myLine = null;
            MyPoint p = new MyPoint();

            while(choice != 10)
            {
                choice = Menu();
                if(choice == 1) { myLine = makeALine(); }
                else if(choice == 2 && myLine != null) { Console.Clear(); beginPointChange(myLine); Console.ReadKey(); }
                else if (choice == 3 && myLine != null) { Console.Clear(); endPointChange(myLine); Console.ReadKey(); }
                else if (choice == 4 && myLine != null) { Console.Clear(); showThePoint(myLine.getBegin()); Console.ReadKey(); }
                else if (choice == 5 && myLine != null) { Console.Clear(); showThePoint(myLine.getEnd()); Console.ReadKey(); }
                else if (choice == 6 && myLine != null) { Console.Clear(); getTheLength(myLine); Console.ReadKey(); }
                else if (choice == 7 && myLine != null) { Console.Clear(); getTheGradient(myLine); Console.ReadKey(); }
                else if (choice == 8 && myLine != null) { Console.Clear(); getDistanceOfBeginPointFromZero(myLine.getBegin()); Console.ReadKey(); }
                else if (choice == 9 && myLine != null) { Console.Clear(); getDistanceOfEndPointFromZero(myLine.getEnd()); Console.ReadKey(); }
            }
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1.Make a Line");
            Console.WriteLine("2.Update the begin point");
            Console.WriteLine("3.Update the end point");
            Console.WriteLine("4.Show the begin Point");
            Console.WriteLine("5.Show the end point");
            Console.WriteLine("6.Get the Length of the line");
            Console.WriteLine("7.Get the Gradient of the Line");
            Console.WriteLine("8.Find the distance of begin point from zero coordinates");
            Console.WriteLine("9.Find the distance of end point from zero coordinates");
            Console.WriteLine("10.Exit");
            Console.WriteLine("Enter Choice: ");
            return int.Parse(Console.ReadLine());
        }
        static MyLine makeALine()
        {
            int X1 = 0;
            int Y1 = 0;
            int X2 = 0;
            int Y2 = 0;
            Console.WriteLine("Enter X1 coord: "); X1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1 coord: "); Y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter X2 coord: "); X2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2 coord: "); Y2 = int.Parse(Console.ReadLine());

            MyPoint p1 = new MyPoint(X1, Y1);
            MyPoint p2 = new MyPoint(X2, Y2);

            MyLine myLine = new MyLine(p1, p2);
            return myLine;
        }

        static void beginPointChange(MyLine myLine)
        {
            int X = 0; int Y = 0;
            Console.WriteLine("Enter new value of X: "); X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new value of Y: "); Y = int.Parse(Console.ReadLine());
            MyPoint p = new MyPoint(X, Y);
            myLine.setBegin(p);
        }
        static void endPointChange(MyLine myLine)
        {
            int X = 0; int Y = 0;
            Console.WriteLine("Enter new value of X: "); X = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new value of Y: "); Y = int.Parse(Console.ReadLine());
            MyPoint p = new MyPoint(X, Y);
            myLine.setEnd(p);
        }
        static void showThePoint(MyPoint p)
        {
            Console.WriteLine("Points: " + p.getX() + ", " + p.getY());
        }
        static void getTheLength(MyLine myLine)
        {
            Console.WriteLine("Length of Line:" + myLine.getLength());
        }
        static void getTheGradient(MyLine myLine)
        {
            Console.WriteLine("Gradient of Line:" + myLine.getGradient());
        }
        static void getDistanceOfBeginPointFromZero(MyPoint p)
        {
            Console.WriteLine("Distance from zero point is: " + p.distanceWithZero());
        }
        static void getDistanceOfEndPointFromZero(MyPoint p)
        {
            Console.WriteLine("Distance from zero point is: " + p.distanceWithZero());
        }
    }
}
