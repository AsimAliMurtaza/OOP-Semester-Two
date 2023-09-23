using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    internal class Student
    {
        public string Name;
        public int Age;
        public int FSC;
        public int Ecat;
        public float Merit;
        public static List<Subject> registeredSubjects = new List<Subject>();
        public List<String> Preference = new List<String>();
        public static Degree enrolledDegree = new Degree();

        public float calculateMerit()
        {
            float merit = 0;
            merit = (((float)FSC / 1100) * 60 + ((float)(Ecat / 400) * 40));
            return merit;
        }
        public static void generateMerit(List<Degree> degrees, List<Student> students)
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

        public static void registerSubject(List<Student> students, List<Degree> degrees)
        {
            Subject returnedSubject = new Subject();
            int tempCredit = 0;
            Console.WriteLine("Enter name of Student: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Subject Code to register: ");
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

        public static int calculateFee()
        {
            int fee = 0;
            foreach(var subject in registeredSubjects) 
            {
                fee = fee + subject.subjectFee;
            }
            return fee;
        }

        public static void sortList(List<Student> students)
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
}