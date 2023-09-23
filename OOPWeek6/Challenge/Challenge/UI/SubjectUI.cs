using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.UI
{
    internal class SubjectUI
    {
        public static void viewSubjects(Student student)
        {
            if(Student.registeredSubjects != null)
            {
                foreach(var x in Student.registeredSubjects)
                {
                    Console.WriteLine(x.SubjectCode+"\t"+x.SubjectType+"\t"+x.CreditHours);
                }
            }
        }
    }
}
