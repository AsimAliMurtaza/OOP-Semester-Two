using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class HGhost : Ghost
    {
        private bool isMoving;
        public HGhost(char H, GameCell g) : base(H, g)
        {

            this.CurrentCell = g;
            this.DisplayCharacter = H;
            this.isMoving = true;
        }

        public override GameCell move()
        {

            GameCell cell;
            if (isMoving)
            {
                cell = this.CurrentCell.nextCell(GameDirection.Left);
                if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                {
                    CurrentCell = cell;
                }
                else
                {
                    isMoving = false;
                    cell = this.CurrentCell.nextCell(GameDirection.Right);
                    if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                    {
                        CurrentCell = cell;
                    }
                }
            }
            else
            {
                cell = this.CurrentCell.nextCell(GameDirection.Right);
                if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                {
                    CurrentCell = cell;
                }
                else
                {
                    isMoving = true;
                    cell = this.CurrentCell.nextCell(GameDirection.Left);
                    if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                    {
                        CurrentCell = cell;
                    }
                }
            }
            return cell;
        }
    }
}
