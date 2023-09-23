using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GL
{
    internal class GameObject
    {
        public char DisplayCharacter;
        public GameCell CurrentCell;
        public GameObjectType gameObjectType;
        
        public GameObject(GameObjectType type, char DisplayCharacter)
        {
            this.DisplayCharacter = DisplayCharacter;
            this.gameObjectType = type;
        }

        public static GameObjectType GetGameObjectType(string displayCharacter)
        {
            if(displayCharacter == "")
            {
                return GameObjectType.None;
            }
            else if(displayCharacter =="p")
            {
                return GameObjectType.Player;
            }
            else if (displayCharacter == ".")
            {
                return GameObjectType.Reward;
            }
            else if (displayCharacter == "G")
            {
                return GameObjectType.Enemy;
            }
            else if(displayCharacter == "#" || displayCharacter == "|" || displayCharacter == "%")
            {
                return GameObjectType.Wall;
            }
            return GameObjectType.None;
        }
    }
}
