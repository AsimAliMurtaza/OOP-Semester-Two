using ChallengeTwo.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChallengeTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            char[,] triangle = new char[5, 3] { { '@', ' ', ' ' }, { '@', '@', ' ' }, { '@', '@', '@' }, { '@', '@', ' ' }, { '@', ' ', ' ' } };
            char[,] opTriangle = new char[5, 3] { { ' ', ' ', '@' }, { ' ', '@', '@' }, { '@', '@', '@' }, { ' ', '@', '@' }, { ' ', ' ', '@' } };

            Boundary boundary = new Boundary();

            GameObject gameObject1 = new GameObject(triangle, new Point(5, 5), boundary, "LeftToRight");
            GameObject gameObject2 = new GameObject(opTriangle, new Point(80, 30), boundary, "RightToLeft");

            List<GameObject> list = new List<GameObject>();
            list.Add(gameObject1);
            list.Add(gameObject2); ;
            while (true)
            {
                Thread.Sleep(200);
                foreach (GameObject game in list)
                {
                    game.Erase();
                    game.move();
                    game.Draw();
                }
            }
        }
    }
}
