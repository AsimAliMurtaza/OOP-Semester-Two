using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2
{
    internal class MUser
    {
        public string Name;
        public string Password;
        public string Role;
        public MUser(string n, string p, string r) 
        {
            Name = n;
            Password = p;
            Role = r;
        }
    }

}
