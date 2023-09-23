using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal abstract class Ghost:GameObject
    {
        public Ghost(char V, GameCell g):base(GameObjectType.Enemy, V)
        { }

        public abstract GameCell move();
    }
}
