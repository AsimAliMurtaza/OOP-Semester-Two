using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.BL
{
    internal class Truck
    {
        public Ladder ladder;
        public HosePipe pipe;

        public Truck(float len, string col)
        {
            this.ladder = new Ladder(len, col);
        }

        public void setHose(HosePipe pipe)
        {
            this.pipe = pipe;
        }
    }
}
