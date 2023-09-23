using ChallengeOne.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FireFighter F = new FireFighter("asim", "captain", 20, "0312-1311341");
            Truck T = new Truck(1.4F, "Green");

            Console.WriteLine(F.name);
            Console.WriteLine(F.phone);
            Console.WriteLine(F.rank);
            Console.WriteLine(T.ladder.colour);
            Console.ReadKey();

        }
    }
}
