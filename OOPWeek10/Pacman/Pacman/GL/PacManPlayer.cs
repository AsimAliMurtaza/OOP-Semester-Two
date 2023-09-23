using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class PacManPlayer:GameObject
    {
        public PacManPlayer(char p, GameCell gc):base(GameObjectType.Player, p)
        {
            this.CurrentCell = gc;
            this.DisplayCharacter = p;
        }
        public GameCell move(GameDirection dir)
        {
            if(CurrentCell.nextCell(dir).CurrentGameObject.gameObjectType == GameObjectType.None)
            {
                CurrentCell = CurrentCell.nextCell(dir);
            }
            return CurrentCell;
        }
    }
}
