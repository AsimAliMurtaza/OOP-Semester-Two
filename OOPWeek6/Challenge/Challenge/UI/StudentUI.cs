using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.UI
{
    internal class StudentUI
    {
        public static Student getStudentInput(List<Degree> degree)
        {
            Student student = new Student();

            Console.Write("Enter Student Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.Write("Enter FSC MArks: ");
            student.FSC = int.Parse(Console.ReadLine());
            Console.Write("Enter Ecat marks: ");
            student.Ecat = int.Parse(Console.ReadLine());
            foreach (var x in degree)
            {
                Console.WriteLine(x.Title);
            }
            Console.Write("Enter how many preference to enter: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                student.Preference.Add(Console.ReadLine());
            }
            return student;
        }
        public static void showStudents(List<Student> students)
        {
            Console.WriteLine("Name \t Age \t FSC \t ECAT");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].Name + "\t" + students[i].Age + "\t" + students[i].FSC + "\t" + students[i].Ecat);
            }
            Console.WriteLine();
        }

    }
}
