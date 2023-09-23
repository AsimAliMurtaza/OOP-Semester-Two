using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class StudentUI
    {
        public static Student getStudentInput()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter adderss");
            string address = Console.ReadLine();
            Console.WriteLine("Enter program: ");
            string program = Console.ReadLine();
            Console.WriteLine("Enter year");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fee");
            double fee = double.Parse(Console.ReadLine());
            Student s = new Student(name, address, program, year, fee);
            return s;
        }
    }
}
