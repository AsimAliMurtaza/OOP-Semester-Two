using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    internal class Subject
    {
        public string SubjectCode;
        public int CreditHours;
        public string SubjectType;
        public int subjectFee;

        public Subject() { }
        public Subject(string subjectCode, int creditHours, string subjectType, int subjectFee)
        {
            SubjectCode = subjectCode;
            CreditHours = creditHours;
            SubjectType = subjectType;
            this.subjectFee = subjectFee;
        }
    }
}
