using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.UI
{
    internal class DegreeUI
    {
        public static Degree getDegreeInput()
        {
            Degree deg = new Degree();

            Console.Write("Add Name of degree Program: ");
            deg.Title = Console.ReadLine();
            Console.Write("Add Duration: ");
            deg.Duration = int.Parse(Console.ReadLine());
            Console.Write("Enter Seats: ");
            deg.Seats = int.Parse(Console.ReadLine());
            Console.Write("Enter how many subjects to enter: ");
            int degree = int.Parse(Console.ReadLine());

            for (int i = 0; i < degree; i++)
            {
                Subject subject = new Subject();
                Console.Write("Enter subject Code: ");
                subject.SubjectCode = Console.ReadLine();
                Console.Write("Enter subject Type: ");
                subject.SubjectType = Console.ReadLine();
                Console.Write("Enter CH: ");
                subject.CreditHours = int.Parse(Console.ReadLine());
                Console.Write("Enter Fee of Subject: ");
                subject.subjectFee = int.Parse(Console.ReadLine());
                deg.Subjects.Add(subject);
            }
            return deg;
        }
        public static string getDegreeNameInput()
        {
            Console.Write("Enter a Programme name: ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
