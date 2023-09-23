using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.BL;
using UAMS.UI;

namespace UAMS.DL
{
    internal class SubjectCRUD
    {
        public static List<Subject> subjectlist = new List<Subject>();
        public static void addSubjectintoList(Subject s)
        {
            subjectlist.Add(s);
        }

        public static Subject isSubjectExists(string type)
        {
            foreach (Subject s in subjectlist)
            {
                if (s.SubjectType == type)
                {
                    return s;
                }
            }
            return null;
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
                    string code = splittedRecord[0];
                    string type = splittedRecord[1];
                    int creditHours = int.Parse(splittedRecord[2] );
                    int subjectFees = int.Parse(splittedRecord[3] );
                    Subject s = new Subject(code, creditHours, type, subjectFees);
                    addSubjectintoList(s);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void storeintoFile(string path, Subject s)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(s.SubjectCode + "," + s.SubjectType + "," + s.CreditHours + "," + s.subjectFee);
            f.Flush();
            f.Close();
        }
    }
}