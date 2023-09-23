using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class GameGrid
    {
        public GameCell[,] GameCells;
        public int Rows;
        public int Columns;

        public GameGrid(string filename, int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            GameCells = new GameCell[Rows,Columns];
            LoadGrid(filename);
        }
        public GameCell GetCell(int x, int y)
        {
            {
                return GameCells[x,y];
            }
        }
        public void LoadGrid(string filename)
        {
            StreamReader fp = new StreamReader(filename);
            string record;
            int row = 0;
            while ((record = fp.ReadLine()) != null)
            {
                for (int x = 0; x < 71; x++)
                {
                    GameCell gc = new GameCell(row, x, this);
                    Char val = record[x];
                    GameObjectType t = GameObject.GetGameObjectType(val.ToString());
                    gc.CurrentGameObject = new GameObject(t, val);
                    gc.CurrentGameObject.CurrentCell = gc;
                    GameCells[row,x] = gc;
                }
                row++;
            }

            fp.Close();
        }
    }
}
