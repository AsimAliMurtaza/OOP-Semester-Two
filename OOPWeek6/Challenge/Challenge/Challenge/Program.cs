using Challenge.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            List<Degree> degree = new List<Degree>();

            Degree degrees = new Degree();
            Student students = new Student();
        
            int choice = 0;
            while(choice != 8)
            {
                
                choice = menuInterface();

                if(choice==2)
                {
                    Console.Clear();
                    degree.Add(degrees.AddDegreeProgram());
                    Console.ReadKey();
                }
                else if(choice==1)
                {
                    Console.Clear();
                    student.Add(students.AddStudent(degree));
                    Console.ReadKey();
                }
                else if(choice==3)
                {
                    Console.Clear();
                    students.generateMerit(degree, student);
                    Console.ReadKey();
                }
                else if(choice==4)
                {
                    Console.Clear();
                    showStudents(student);
                    Console.ReadKey();
                }
                else if(choice==5)
                {
                    Console.Clear();
                    degrees.specificProgramme(student);
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }

        static int menuInterface()
        {
            Console.WriteLine("1. Add Student.");
            Console.WriteLine("2. Add Degree Program.");
            Console.WriteLine("3. Generate Merit.");
            Console.WriteLine("4. View Registered Users.");
            Console.WriteLine("5. View Students for a specific Program.");
            Console.WriteLine("6. Register subjects for a particular Student.");
            Console.WriteLine("7. Calculate fee for all registered Students.");
            Console.WriteLine("8. Exit.");
            Console.WriteLine("Enter Option: ");
            int choice = int.Parse(Console.ReadLine());

            return choice;
        }

        static void showStudents(List<Student> students)
        {
            Console.WriteLine("Name \t Age \t FSC \t ECAT");
            for(int i = 0; i<students.Count; i++)
            {
                Console.WriteLine(students[i].Name + "\t" + students[i].Age + "\t" + students[i].FSC + "\t" + students[i].Ecat);
            }
            Console.WriteLine();
        }
    }
}
