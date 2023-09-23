using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UAMS.BL;
using UAMS.UI;

namespace UAMS.DL
{
    internal class DegreeCRUD
    {
        public static List<Degree> degrees = new List<Degree>();

        public static void AddDegreeProgram(Degree degree)
        {
            degrees.Add(degree);
        }

        public static bool isDegreeExist(string DegreeName)
        {
            foreach (var degree in degrees)
            {
                if (degree.Title == DegreeName) return true;
            }
            return false;
        }
        public static void getSpecificProgramme(string name)
        {
            foreach (var degree in degrees)
            {
                if (name == degree.Title)
                {
                    foreach (var student in degree.Students)
                    {
                        Console.WriteLine(student.Name + "\t" + student.Age + "\t" + student.FSC + "\t" + student.Ecat);
                    }
                }
            }
        }

        public static void storeintofile(string path, Degree d)
        {
            StreamWriter f = new StreamWriter(path, true);
            string SubjectNames = "";
            for (int x = 0; x < d.Subjects.Count - 1; x++)
            {
                SubjectNames = SubjectNames + d.Subjects[x].SubjectType + ";";
            }
            SubjectNames = SubjectNames + d.Subjects[d.Subjects.Count - 1].SubjectType;
            f.WriteLine(d.Title + "," + d.Duration + "," + d.Seats + "," + SubjectNames);
            f.Flush();
            f.Close();
        }

        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string degreeName = splittedRecord[0];
                    int degreeDuration = int.Parse(splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    string[] splittedRecordForSubject = splittedRecord[3].Split(';');
                    Degree d = new Degree(degreeName, degreeDuration, seats);
                    for (int x = 0; x < splittedRecordForSubject.Length; x++)
                    {
                        Subject s = SubjectCRUD.isSubjectExists(splittedRecordForSubject[x]);
                        if (s != null)
                        {
                            Degree.addSubjectintoList(s);
                        }
                        AddDegreeProgram(d);
                    }
                    f.Close();
                    return true;
                }
            }
            return false;
        }
    }
}