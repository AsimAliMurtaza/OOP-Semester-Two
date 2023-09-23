using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTwo.UI
{
    internal class DriverUI
    {
        public static void Draw(char[,] shape, int x, int y)
        {
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.Write(shape[i, j]);
                }
            }
        }
        public static void Erase(char[,] shape, int x, int y)
        {
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    Console.Write(' ');
                }
            }
        }
    }
}
