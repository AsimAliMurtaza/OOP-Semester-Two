using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class SGhost:Ghost
    {
        private PacManPlayer pacman;
        public SGhost(char H, GameCell g, PacManPlayer p) : base(H, g)
        {

            this.CurrentCell = g;
            this.DisplayCharacter = H;
            this.pacman = p;
        }
        public override GameCell move()
        {
            GameCell cell;
            cell = CurrentCell;
            double shortestDistance = CalculateDistance(CurrentCell, pacman.CurrentCell);

            List<GameCell> neighborCells = new List<GameCell> ();
            neighborCells.Add(this.CurrentCell.nextCell(GameDirection.Left));
            neighborCells.Add(this.CurrentCell.nextCell(GameDirection.Right));
            neighborCells.Add(this.CurrentCell.nextCell(GameDirection.Up));
            neighborCells.Add(this.CurrentCell.nextCell(GameDirection.Down));

            foreach (GameCell neighborCell in neighborCells)
            {
                if (neighborCell.CurrentGameObject.gameObjectType == GameObjectType.None || neighborCell.CurrentGameObject.gameObjectType == GameObjectType.Reward)
                {
                    double distance = CalculateDistance(neighborCell, pacman.CurrentCell);
                    if (distance < shortestDistance)
                    {
                        shortestDistance = distance;
                        cell = neighborCell;
                    }
                }
            }
            CurrentCell = cell;
            return CurrentCell;
        }
        private double CalculateDistance(GameCell cell1, GameCell cell2)
        {
            int x1 = cell1.x;
            int y1 = cell1.y;
            int x2 = cell2.x;
            int y2 = cell2.y;
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
