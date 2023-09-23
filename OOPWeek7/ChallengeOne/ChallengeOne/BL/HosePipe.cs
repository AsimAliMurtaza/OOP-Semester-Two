using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.BL
{
    internal class HosePipe
    {
        public bool isRubber;
        public bool isPlastic;
        public bool isCylindrical;
        public bool isCircular;
        public float diameter;
        public float flowRate;
        
        public HosePipe(bool isRubber, bool isPlastic, bool isCylindrical, bool isCircular, float diameter, float flowRate)
        {
            this.isRubber = isRubber;
            this.isPlastic = isPlastic;
            this.isCylindrical = isCylindrical;
            this.isCircular = isCircular;
            this.diameter = diameter;
            this.flowRate = flowRate;
        }
    }
}
