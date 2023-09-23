using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;

namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Asim Ali\\source\\repos\\GameConsole\\GameConsole\\obj\\Debug\\maze.txt";

            int score = 0;
            int choice = 0;
            int trigger = 0;
            int healthPlayer = 100;
            int healthEnemyOne = 200;

            int playerX = 3;
            int playerY = 15;
            int enemyOneX = 40;
            int enemyOneY = 3;

            string directionEnemyOne = "right";

            bool[] isBulletRight = new bool[10000];
            int[] bulletX = new int[10000];
            int[] bulletY = new int[10000];
            bool[] isBullet = new bool[10000];
            int bulletCount = 0;

            int[] bulletXOpposite = new int[10000];
            int[] bulletYOpposite = new int[10000];
            bool[] isBulletOpposite = new bool[10000];
            int bulletCountOpposite = 0;

            int[] bulletXEnemy = new int[10000];
            int[] bulletYEnemy = new int[10000];
            bool[] isBulletEnemy = new bool[10000];
            int bulletCountEnemy = 0;

            char[,] playerMove = {
                { ' ', ' ', 'A', ' ', ' ', ' '},
                { '<', '[', 'A', ']', '>', ' '},
                { ' ', '/', ' ', '\\', ' ', ' '}
                };

            char[,] enemyOneMove = {
                { ' ', ' ', 'M', ' ', ' ', ' '},
                { '<', '/', '|', '\\', '>', ' '},
                { ' ', 'T', ' ', 'T', ' ', ' '}
                };

            char[,] maze = new char[46,162];

            bool gameRunning = true;

            while (choice != 3)
            {
                menu();
                choice = option();

                if (choice == 1)
                {
                    readMazeFromFile(ref path, ref maze);
                    gameRunning = true;
                    printMaze(ref maze);

                    while (gameRunning)
                    {
                        Thread.Sleep(10);
                        printPlayer(ref playerX, ref playerY, ref playerMove);
                        
                        if (EZInput.Keyboard.IsKeyPressed(Key.UpArrow))
                        {
                            moveUp(ref playerX, ref playerY, ref playerMove, ref maze);
                        }
                        if (EZInput.Keyboard.IsKeyPressed(Key.DownArrow))
                        {
                            moveDown(ref playerX, ref playerY, ref playerMove, ref maze);
                        }
                        if (EZInput.Keyboard.IsKeyPressed(Key.LeftArrow))
                        {
                            moveLeft(ref playerX, ref playerY, ref playerMove, ref maze);
                        }
                        if (EZInput.Keyboard.IsKeyPressed(Key.RightArrow))
                        {
                            moveRight(ref playerX, ref playerY, ref playerMove, ref maze);
                        }
                        if (EZInput.Keyboard.IsKeyPressed(Key.Space))
                        {
                            createBullet(ref playerX, ref playerY, ref bulletX, ref bulletY, ref isBullet, ref isBulletRight, ref bulletCount);
                        }
                        if (EZInput.Keyboard.IsKeyPressed(Key.Z))
                        {
                            createBulletOpposite(ref playerX,ref playerY,ref isBulletRight, ref bulletXOpposite,ref bulletYOpposite,ref isBulletOpposite,ref bulletCountOpposite);
                        }
                        if(trigger<=0)
                        {
                            if(healthEnemyOne>=0)
                            {
                                createBulletEnemy(ref enemyOneX, ref enemyOneY, ref bulletXEnemy, ref bulletYEnemy, ref isBulletEnemy, ref bulletCountEnemy);
                                trigger = 5;
                            }
                        }
                        trigger--;

                        if(healthEnemyOne>0)
                        {
                            printEnemyOne(ref enemyOneX, ref enemyOneY, ref enemyOneMove);
                            moveEnemyOne(ref directionEnemyOne, ref enemyOneX, ref enemyOneY, ref enemyOneMove);
                            printHealthEnemyOne(ref healthEnemyOne);
                            playerCollision(ref healthPlayer, ref playerX, ref playerY, ref enemyOneX, ref enemyOneY);
                            collisionWithEnemyBullet(ref bulletCountEnemy, ref isBulletEnemy, ref bulletXEnemy, ref bulletYEnemy, ref healthPlayer, ref playerX, ref playerY);
                        }
                        else if(healthEnemyOne<=0)
                        {
                            removeChar(ref enemyOneX, ref enemyOneY);
                        }
                        moveBulletEnemy(ref bulletXEnemy, ref bulletYEnemy, ref isBulletEnemy, ref bulletCountEnemy, ref maze);
                        moveBullet(ref bulletX, ref bulletY, ref isBullet, ref isBulletRight, ref bulletCount, ref bulletXOpposite, ref bulletYOpposite, ref isBulletOpposite, ref bulletCountOpposite, ref maze, ref playerX, ref playerY);
                        printCounters(ref healthPlayer, ref score);
                        collisionWithPlayerBullet(ref bulletCount, ref isBullet, ref bulletX, ref bulletY, ref score, ref healthEnemyOne, ref enemyOneX, ref enemyOneY);
                    }
                }
            }
        }
        static void menu()
        {
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Options");
            Console.WriteLine("3. Exit");
        }
        static int option()
        {
            int option = 0;
            Console.Write("Enter a choice: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void printMaze(ref char[,] maze)
        {
            for (int i = 0; i < 46; i++)
            {
                Console.SetCursorPosition(0, 0 + i);
                for (int j = 0; j < 162; j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void printCounters(ref int healthPlayer, ref int score)
        {
            string empty = " ";
            //prints healths of all characters
            Console.SetCursorPosition(165, 3);
            Console.WriteLine("Score: {0} {1}", score, empty);
            Console.SetCursorPosition(165, 5);
            Console.WriteLine("Atlas Health: {0} {1}", healthPlayer, empty);
        }

        static void printHealthEnemyOne(ref int healthEnemyOne)
        {
            string empty = " ";
            Console.SetCursorPosition(165, 7);
            Console.WriteLine("Mechanoid Health: {0} {1}", healthEnemyOne, empty);
        }
        static void printPlayer(ref int x, ref int y, ref char[,] playerMove)
        {
            //prints player
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(playerMove[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void printEnemyOne(ref int x, ref int y, ref char[,] enemyOneMove)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(enemyOneMove[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void moveUp(ref int playerX, ref int playerY, ref char[,] playerMove, ref char[,] maze)
        {
            //makes player go up
            bool isFlag = false;
            
            for(int i = 0;i < 6;i++)
            {
                if (maze[playerY - 1, playerX + i] == '#')
                {
                    isFlag = true;
                }
            }
            if (!(isFlag))
            {
                removeChar(ref playerX, ref playerY);
                playerY--;
                printPlayer(ref playerX, ref playerY, ref playerMove);
            }
        }
        static void moveDown(ref int playerX, ref int playerY, ref char[,] playerMove, ref char[,] maze)
        {
            //makes player go down
            bool isFlag = false;
            for (int i = 0; i < 6; i++)
            {
                if (maze[playerY + 3, playerX + i] == '#')
                {
                    isFlag = true;
                }
            }
            if (!(isFlag))
            {
                removeChar(ref playerX, ref playerY);
                playerY++;
                printPlayer(ref playerX, ref playerY, ref playerMove);
            }
        }
        static void moveRight(ref int playerX, ref int playerY, ref char[,] playerMove, ref char[,] maze)
        {
            //makes player go right
            bool isFlag = false;
            for (int i = 0; i < 3; i++)
            {
                if (maze[playerY + i, playerX + 6] == '#')
                {
                    isFlag = true;
                }
            }
            if (!(isFlag))
            {
                removeChar(ref playerX, ref playerY);
                playerX++;
                printPlayer(ref playerX, ref playerY, ref playerMove);
            }
        }
        static void moveLeft(ref int playerX, ref int playerY, ref char[,] playerMove, ref char[,] maze)
        {
            //makes player go left
            bool isFlag = false;
            for (int i = 0; i < 3; i++)
            {
                if (maze[playerY + i, playerX - 1] == '#')
                {
                    isFlag = true;
                }
            }
            if (!(isFlag))
            {
                removeChar(ref playerX, ref playerY);
                playerX--;
                printPlayer(ref playerX, ref playerY, ref playerMove);
            }
        }
        static void moveEnemyOne(ref string directionEnemyOne, ref int enemyOneX, ref int enemyOneY, ref char[,] enemyOneMove)
        {
            //moves enemy one depending on direction
            if (directionEnemyOne == "right") // enemy one movement
            {
                if (enemyOneX >= 40)
                {
                    directionEnemyOne = "left";
                }
                removeChar(ref enemyOneX, ref enemyOneY);
                enemyOneX = enemyOneX + 1;
                printEnemyOne(ref enemyOneX, ref enemyOneY, ref enemyOneMove);
            }
            if (directionEnemyOne == "left")
            {
                if (enemyOneX <= 10)
                {
                    directionEnemyOne = "right";
                }
                removeChar(ref enemyOneX, ref enemyOneY);
                enemyOneX = enemyOneX - 1;
                printEnemyOne(ref enemyOneX, ref enemyOneY, ref enemyOneMove);
            }
        }
        static void removeChar(ref int x, ref int y)
        {
            //removes player and enemies
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x, y + i);
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void printBullet(ref int x, ref int y)
        {
            // prints bullets of player on either sides
            Console.SetCursorPosition(x, y);
            Console.Write(".");
        }
        static void eraseBullet(ref int x, ref int y)
        {
            // removes bullets of player on either sides
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
        static void createBullet(ref int playerX, ref int playerY, ref int[] bulletX, ref int[] bulletY, ref bool[] isBullet, ref bool[] isBulletRight, ref int bulletCount)
        {
            // creates bullets of player on right side
                bulletX[bulletCount] = playerX + 6;
                bulletY[bulletCount] = playerY + 1;
                isBullet[bulletCount] = true;
                isBulletRight[bulletCount] = true;
                Console.SetCursorPosition(playerX + 6, playerY + 1);
                Console.Write(".");
                bulletCount++;
        }
        static void createBulletOpposite(ref int playerX,ref int playerY,ref bool[] isBulletRight, ref int[] bulletXOpposite,ref int[] bulletYOpposite, ref bool[] isBulletOpposite, ref int bulletCountOpposite)
        {
            // creates bullets of player on left side
            if ((playerX - 1) != '#')
            {
                bulletXOpposite[bulletCountOpposite] = playerX - 1;
                bulletYOpposite[bulletCountOpposite] = playerY + 1;
                isBulletOpposite[bulletCountOpposite] = true;
                isBulletRight[bulletCountOpposite] = false;
                Console.SetCursorPosition(playerX - 1, playerY + 1);
                Console.Write(".");
                bulletCountOpposite++;
            }
        }
        static void moveBullet(ref int[] bulletX, ref int[] bulletY, ref bool[] isBullet, ref bool[] isBulletRight, ref int bulletCount, ref int[] bulletXOpposite, ref int[] bulletYOpposite, ref bool[] isBulletOpposite, ref int bulletCountOpposite, ref char[,] maze, ref int playerX, ref int playerY)
        {
            // moves bullets of player on right side
            for (int i = 0; i < bulletCount; i++)
            {
                if (isBulletRight[i])
                {
                    if (isBullet[i] == true)
                    {
                        if (maze[bulletY[i], bulletX[i] + 1] == '#')
                        {
                            eraseBullet(ref bulletX[i], ref bulletY[i]);
                            makeBulletinactive(ref i, ref isBullet);
                        }
                        else
                        {
                            eraseBullet(ref bulletX[i],ref bulletY[i]);
                            bulletX[i] = (bulletX[i] + 1);
                            printBullet(ref bulletX[i],ref bulletY[i]);
                        }
                    }
                }
            }
            for (int i = 0; i < bulletCountOpposite; i++)
            {
                if (!(isBulletRight[i]))
                {
                    if (isBulletOpposite[i] == true)
                    {
                        if (maze[bulletY[i], bulletX[i]] == '#')
                        {
                            eraseBullet(ref bulletXOpposite[i], ref bulletYOpposite[i]);
                            makeBulletinactiveOpposite(ref i, ref isBulletOpposite);
                        }
                        else
                        {
                            eraseBullet(ref bulletXOpposite[i],ref bulletYOpposite[i]);
                            bulletXOpposite[i] = (bulletXOpposite[i] - 1);
                            printBullet(ref bulletXOpposite[i],ref bulletYOpposite[i]);
                        }
                    }
                }
            }
        }
        static void makeBulletinactive(ref int index, ref bool[] isBullet)
        {
            // makes bullets of player inactive on previous coord
            isBullet[index] = false;
        }
        static void makeBulletinactiveOpposite(ref int index, ref bool[] isBulletOpposite)
        {
            // makes bullets of player inactive on previous coord
            isBulletOpposite[index] = false;
        }
        static void createBulletEnemy(ref int enemyOneX,ref int enemyOneY, ref int[] bulletXEnemy,ref int[] bulletYEnemy, ref bool[] isBulletEnemy, ref int bulletCountEnemy)
        {
            // creates bullets of enemy one
            bulletXEnemy[bulletCountEnemy] = enemyOneX;
            bulletYEnemy[bulletCountEnemy] = enemyOneY + 3;
            isBulletEnemy[bulletCountEnemy] = true;
            Console.SetCursorPosition(enemyOneX, enemyOneY + 3);
            Console.Write("+");
            bulletCountEnemy++;
        }
        static void moveBulletEnemy(ref int[] bulletXEnemy, ref int[] bulletYEnemy, ref bool[] isBulletEnemy, ref int bulletCountEnemy, ref char[,] maze)
        {
            // moves bullets of enemy one
            for (int i = 0; i < bulletCountEnemy; i++)
            {
                if (isBulletEnemy[i] == true)
                {
                    if (maze[bulletYEnemy[i] + 1, bulletXEnemy[i]] == '#')
                    {
                        eraseBullet(ref bulletXEnemy[i],ref bulletYEnemy[i]);
                        makeBulletinactiveEnemy(ref i, ref isBulletEnemy);
                    }
                    else
                    {
                        eraseBullet(ref bulletXEnemy[i],ref bulletYEnemy[i]);
                        bulletYEnemy[i] = (bulletYEnemy[i] + 1);
                        printBulletEnemy(ref bulletXEnemy[i], ref bulletYEnemy[i]);
                    }
                }
            }
        }
        static void printBulletEnemy(ref int x, ref int y)
        {
            // prints bullets of enemy one
            Console.SetCursorPosition(x, y);
            Console.Write("+");
        }
        static void makeBulletinactiveEnemy(ref int index, ref bool[] isBulletEnemy)
        {
            // makes bullets of enemy one inactive.
            isBulletEnemy[index] = false;
        }
        static void readMazeFromFile(ref string filePath, ref char[,] maze)
        {
            if (File.Exists(filePath)) 
            {
                string[] line = File.ReadAllLines(filePath);
                int rows = line.Length;
                int columns = line[0].Length;
                char[,] tempArr = new char[rows, columns];

                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < columns; j++)
                    {
                        tempArr[i,j]= line[i][j];
                        maze[i,j]= tempArr[i,j];
                    }
                }
            }
        }

        static void playerCollision(ref int healthPlayer, ref int playerX, ref int playerY, ref int enemyOneX, ref int enemyOneY)
        {
            //detects collision of player with enemies and deducts health
            if (((enemyOneX >= playerX && enemyOneX <= playerX + 6) && (enemyOneY >= playerY && enemyOneY <= playerY + 3)) || ((enemyOneX + 6 >= playerX && enemyOneX + 6 <= playerX + 6) && (enemyOneY >= playerY && enemyOneY <= playerY + 3)) || ((enemyOneX >= playerX && enemyOneX <= playerX + 6) && (enemyOneY + 3 >= playerY && enemyOneY + 3 <= playerY + 3)) || ((enemyOneX + 6 >= playerX && enemyOneX + 6 <= playerX + 6) && (enemyOneY + 3 >= playerY && enemyOneY + 3 <= playerY + 3)))
            {
                healthPlayer--;
            }
        }
        static void collisionWithPlayerBullet(ref int bulletCount, ref bool[] isBullet, ref int[] bulletX, ref int[] bulletY, ref int score, ref int healthEnemyOne, ref int enemyOneX, ref int enemyOneY )
        {
            for(int i = 0; i < bulletCount;  i++)
            {
                if (isBullet[i]==true)
                {
                    if ((bulletX[i] + 1 == enemyOneX && bulletY[i] == enemyOneY) || (bulletX[i] + 1 == enemyOneX && bulletY[i] == enemyOneY + 1) || (bulletX[i] + 1 == enemyOneX && bulletY[i] == enemyOneY + 2))
                    {
                        score++;
                        healthEnemyOne -= 50;
                        eraseBullet(ref bulletX[i], ref bulletY[i]);
                        makeBulletinactive(ref i, ref isBullet);
                    }
                }
            }
        }
        static void collisionWithEnemyBullet(ref int bulletCountEnemy, ref bool[] isBulletEnemy, ref int[] bulletXEnemy, ref int[] bulletYEnemy, ref int healthPlayer, ref int playerX, ref int playerY)
        {
            for (int i = 0; i < bulletCountEnemy; i++)
            {
                if (isBulletEnemy[i] == true)
                {
                    if ((bulletXEnemy[i] == playerX && bulletYEnemy[i] + 1 == playerY) || (bulletXEnemy[i]== playerX + 1 && bulletYEnemy[i] + 1 == playerY) || (bulletXEnemy[i] == playerX + 2 && bulletYEnemy[i] == playerY) || (bulletXEnemy[i] == playerX + 3 && bulletYEnemy[i] == playerY) || (bulletXEnemy[i] == playerX + 4 && bulletYEnemy[i] == playerY))
                    {
                        healthPlayer--;
                        eraseBullet(ref bulletXEnemy[i], ref bulletYEnemy[i]);
                        makeBulletinactiveEnemy(ref i, ref isBulletEnemy);
                    }
                }
            }
        }
    }
}
