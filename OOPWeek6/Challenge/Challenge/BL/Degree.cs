using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.BL
{
    internal class Degree
    {
        public string Title;
        public int Duration;
        public int Seats;
        public List<Student> Students = new List<Student>();
        public List<Subject> Subjects = new List<Subject>();

        public Degree() { }

        public Degree(string degreeName, int degreeDuration, int seats)
        {
            Title = degreeName;
            Duration = degreeDuration;
            Seats = seats;
        }
        public static void addSubjectintoList(Subject s)
        {
            Subjects.Add(s);
        }

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
    }
}
