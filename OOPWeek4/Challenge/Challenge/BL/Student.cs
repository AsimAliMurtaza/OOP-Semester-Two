using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge.BL
{
    internal class Student
    {
        public string Name;
        public int Age;
        public int FSC;
        public int Matric;
        public int Ecat;
        public float Merit;
        public List<Subject> registeredSubjects = new List<Subject>();
        public List<String> Preference = new List<String>();
        public Degree enrolledDegree = new Degree();

        public float calculateMerit()
        {
            float merit = 0;
            merit = (((float)FSC / 1100) * 60 + ((float)(Ecat / 400) * 40));
            return merit;
        }
        public Student AddStudent(List<Degree> degree)
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
        public void generateMerit(List<Degree> degrees, List<Student> students)
        {
            students.ForEach(student =>
            {
                student.Merit = student.calculateMerit();
            });
            sortList(students);

            foreach (Student student in students)
            {
                foreach (Degree degree in degrees)
                {
                    foreach (String pref in student.Preference)
                    {
                        if (pref == degree.Title)
                        {
                            if (degree.Seats != 0)
                            {
                                degree.Students.Add(student);
                                degree.Seats--;
                                enrolledDegree = degree;
                                Console.WriteLine(student.Name + " got admission in " + degree.Title);
                            }
                        }
                    }
                }
            }
        }

        public void registerSubject(List<Student> students, List<Degree> degrees)
        {
            Subject returnedSubject = new Subject();
            int tempCredit = 0;
            Console.WriteLine("Enter name of Student: ");
            string name = Console.ReadLine();
            Console.WriteLine("ENter Subject Code to register: ");
            string code = Console.ReadLine();
            foreach(var i in students)
            {
                if(name == i.Name)
                {
                    if(enrolledDegree!=null)
                    {
                        foreach(var subject in registeredSubjects)
                        {
                            tempCredit = tempCredit + subject.CreditHours;
                        }
                        foreach(var x in degrees)
                        {
                            if((tempCredit = tempCredit + (returnedSubject = x.returnSubject(code)).CreditHours)<9)
                            {
                                registeredSubjects.Add(returnedSubject);
                            }
                            else { Console.WriteLine("Credit Hours Exceed 9. Cannot Register!"); }
                        }
                    }
                }
            }
        }

        public int calculateFee()
        {
            int fee = 0;
            foreach(var subject in registeredSubjects) 
            {
                fee = fee + subject.subjectFee;
            }
            return fee;
        }

        public void sortList(List<Student> students)
        {
            string tempName = "";
            int tempFsc = 0;
            int tempEcat = 0;
            float tempMerit = 0;
            for (int i = 0; i < students.Count; i++)
            {
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[i].Merit > students[j].Merit)
                    {
                        tempMerit = students[i].Merit;
                        tempName = students[i].Name;
                        tempFsc = students[i].FSC;
                        tempEcat = students[i].Ecat;

                        students[i].Merit = students[j].Merit;
                        students[i].Name = students[j].Name;
                        students[i].FSC = students[j].FSC;
                        students[i].Ecat = students[j].Ecat;

                        students[j].Merit = tempMerit;
                        students[j].Name = tempName;
                        students[j].FSC = tempFsc;
                        students[j].Ecat = tempEcat;
                    }
                }
            }
        }
    }
    internal class Degree
    {
        public string Title;
        public int Duration;
        public int Seats;
        public List<Student> Students = new List<Student>();
        public List<Subject> Subjects = new List<Subject>();

        public Subject returnSubject(string code)
        {
            Subject sub = new Subject();
            foreach (var x in Subjects)
            {
                if (code == x.SubjectCode)
                {
                    sub = x; break;
                }
            }
            return sub;
        }
        public void specificProgramme(List<Student> degrees)
        {
            Console.Write("Enter a Programme name: ");
            string name = Console.ReadLine();

            foreach (var degree in degrees)
            {
                for (int i = 0; i < degree.Preference.Count; i++)
                {
                    if (name == degree.Preference[i])
                    {
                        Console.WriteLine(degree.Name);
                    }
                }
            }
        }
        public Degree AddDegreeProgram()
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
    }

    internal class Subject
    {
        public string SubjectCode;
        public int CreditHours;
        public string SubjectType;
        public int subjectFee;
    }
}