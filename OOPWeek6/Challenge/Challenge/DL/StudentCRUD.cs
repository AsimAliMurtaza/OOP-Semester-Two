using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;

namespace UAMS.DL
{
    internal class StudentCRUD
    {
        public static List<Student> students = new List<Student>();

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }

        public static void storeintoFile(string path, Student s)
        {
            StreamWriter f = new StreamWriter(path, true);
            string degreeNames = "";
            for (int x = 0; x < s.Preference.Count - 1; x++)
            {
                degreeNames = degreeNames + s.Preference[x].degreeName + ";";
            }
            degreeNames = degreeNames + s.Preference[s.Preference.Count - 1].Title;
            f.WriteLine(s.Name + "," + s.Age + "," + s.FSC + "," + s.Ecat + "," + degreeNames);
            f.Flush();
            f.Close();
        }
    }
}
