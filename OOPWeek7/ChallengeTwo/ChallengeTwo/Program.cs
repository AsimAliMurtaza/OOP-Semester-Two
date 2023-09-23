using ChallengeTwo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike M = new MountainBike(12, 15, 2, 400);
            Console.WriteLine(M.gear);
            M.setGear(4);
            Console.WriteLine(M.gear);
            Console.WriteLine(M.speed);
            M.applyBrake(100);
            Console.WriteLine(M.speed);
            Console.ReadKey();
        }
    }
}
