using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student s1 = StudentUI.getStudentInput();
            Staff st = StaffUI.getStaffInput();
            Student s2 = StudentUI.getStudentInput();
            Staff st2 = StaffUI.getStaffInput();

            DL.addUser(s1);
            DL.addUser(st);
            DL.addUser(s2);
            DL.addUser(st2);

            PersonUI.showInfo(DL.getList());
        }
    }
}
