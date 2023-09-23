using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class VGhost:Ghost
    {
        private bool isMoving;
        public VGhost(char V, GameCell g):base(V, g) {

            this.CurrentCell = g;
            this.DisplayCharacter = V;
            this.isMoving = true;
        }

        public override GameCell move()
        {

            GameCell cell;
            if(isMoving)
            {
                cell = this.CurrentCell.nextCell(GameDirection.Up);
                if(cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                { 
                    CurrentCell = cell;
                }
                else
                {
                    isMoving = false;
                    cell = this.CurrentCell.nextCell(GameDirection.Down);
                    if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                    {
                        CurrentCell = cell;
                    }
                }
            }
            else
            {
                cell = this.CurrentCell.nextCell(GameDirection.Down);
                if (cell != null && cell.CurrentGameObject.gameObjectType != GameObjectType.Wall)
                {
                    CurrentCell = cell;
                }
                else
                {
                    isMoving = true;
                    cell = this.CurrentCell.nextCell(GameDirection.Up);
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
