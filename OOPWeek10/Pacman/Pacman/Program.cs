using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;
using Pacman;
using Pacman.GL;

namespace Pacman
{
    class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            GameCell start = new GameCell(12, 22, grid);
            GameCell startG1 = new GameCell(1, 22, grid);
            GameCell startG2 = new GameCell(1, 22, grid);
            GameCell startG3 = new GameCell(1, 22, grid);
            GameCell startG4 = new GameCell(1, 22, grid);
            PacManPlayer pacman = new PacManPlayer('P', start);

            VGhost ghost1 = new VGhost('V', startG1);
            HGhost ghost2 = new HGhost('H', startG2);
            RGhost ghost3 = new RGhost('R', startG3);
            SGhost ghost4 = new SGhost('S', startG4, pacman);
            List<Ghost> ghosts = new List<Ghost>();
            GameObject newGO = new GameObject(GameObjectType.None, ' ');
            ghosts.Add(ghost1);
            ghosts.Add(ghost2);
            ghosts.Add(ghost3);
            ghosts.Add(ghost4);

            printMaze(grid);
            printGameObject(pacman);

            bool gameRunning = true;
            while (gameRunning)
            {
                foreach(Ghost g in ghosts)
                {
                    clearGameCellContent(g.CurrentCell, newGO);
                    g.move();
                    printGameObject(g);
                }

                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(pacman, GameDirection.Up);
                }


                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    moveGameObject(pacman, GameDirection.Down);
                }


                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, GameDirection.Right);
                }


                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, GameDirection.Left);
                }

                
            }
        }
        static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            Console.SetCursorPosition(gameCell.y, gameCell.x);
            Console.Write(newGameObject.DisplayCharacter);


        }
        static void printGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.CurrentCell.y, gameObject.CurrentCell.x);
            Console.Write(gameObject.DisplayCharacter);
        }


        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.CurrentCell.nextCell(direction);
            if (nextCell != null && nextCell.CurrentGameObject.gameObjectType==GameObjectType.None || nextCell.CurrentGameObject.gameObjectType == GameObjectType.Reward)
            {
                GameObject newGO = new GameObject(GameObjectType.None, ' ');
                GameCell currentCell = gameObject.CurrentCell;
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
            }
        }

        static void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                int abc = 0;
                for (int y = 0; y < grid.Columns; y++)
                {
                    GameCell cell = grid.GetCell(x, y);
                    printCell(cell);
                }


            }
        }


        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.y, cell.x);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }


    }
}