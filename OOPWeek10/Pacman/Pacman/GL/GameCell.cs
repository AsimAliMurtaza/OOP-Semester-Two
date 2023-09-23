using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class GameCell
    {
        public int x;
        public int y;
        public GameObject CurrentGameObject;
        public GameGrid gameGrid;

        public GameCell(int x, int y, GameGrid gameGrid)
        {
            this.x = x;
            this.y = y;
            this.gameGrid= gameGrid;
        }

       public GameCell nextCell(GameDirection direction)
        {
            if(direction==GameDirection.Left)
            {
                return gameGrid.GameCells[x,y-1];
            }
            if (direction == GameDirection.Right)
            {
                return gameGrid.GameCells[x, y + 1];
            }
            if (direction == GameDirection.Up)
            {
                return gameGrid.GameCells[x-1, y];
            }
            if (direction == GameDirection.Down)
            {
                return gameGrid.GameCells[x+1, y];
            }
            return null;
        }
    }
}
