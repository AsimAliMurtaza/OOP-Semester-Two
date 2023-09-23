using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class RGhost:Ghost
    {
        public RGhost(char H, GameCell g) : base(H, g)
        {

            this.CurrentCell = g;
            this.DisplayCharacter = H;
        }
        public override GameCell move()
        {
            GameCell cell;
            int value = ghostDirection();
            if (value == 0)
            {
                cell = this.CurrentCell.nextCell(GameDirection.Left);
                if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                {
                    CurrentCell = cell;
                }
            }
            if (value == 1)
            {
                cell = this.CurrentCell.nextCell(GameDirection.Right);
                if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                {
                    CurrentCell = cell;
                }
            }
            if (value == 2)
            {
                cell = this.CurrentCell.nextCell(GameDirection.Up);
                if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                {
                    CurrentCell = cell;
                }
            }
            if (value == 3)
            {
                cell = this.CurrentCell.nextCell(GameDirection.Down);
                if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                {
                    CurrentCell = cell;
                }
            }

            return CurrentCell;
        }

        public int ghostDirection()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }
    }
}
