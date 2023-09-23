using UAMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UAMS.UI;
using UAMS.DL;

namespace UAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriverMenuUI.Header();
            int choice = 0;
            while(choice != 8)
            {
                choice = DriverMenuUI.menuInterface();
                
                if(choice==1)
                {
                    Console.Clear();
                    DriverMenuUI.Header();
                    Student student = StudentUI.getStudentInput(DegreeCRUD.degrees);
                    StudentCRUD.AddStudent(student);
                    Console.ReadKey();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    DriverMenuUI.Header();
                    Degree degree = DegreeUI.getDegreeInput();
                    DegreeCRUD.AddDegreeProgram(degree);
                    Console.ReadKey();
                }
                else if(choice==3)
                {
                    Console.Clear();
                    DriverMenuUI.Header();
                    Student.generateMerit(DegreeCRUD.degrees, StudentCRUD.students);
                    Console.ReadKey();
                }
                else if(choice==4)
                {
                    Console.Clear();
                    DriverMenuUI.Header();
                    StudentUI.showStudents(StudentCRUD.students);
                    Console.ReadKey();
                }
                else if(choice==5)
                {
                    Console.Clear();
                    DriverMenuUI.Header();
                    string degreeName = DegreeUI.getDegreeNameInput();
                    if(DegreeCRUD.isDegreeExist(degreeName))
                    {
                        DegreeCRUD.getSpecificProgramme(degreeName);
                    }
                    Console.ReadKey();
                }
                else if (choice == 6)
                {
                    Console.Clear();
                    DriverMenuUI.Header();
                    Student.registerSubject(StudentCRUD.students, DegreeCRUD.degrees);
                    Console.ReadKey();
                }
                else if (choice == 7)
                {
                    Console.Clear();
                    DriverMenuUI.Header();
                    Console.WriteLine("TOTAL FEE: "+ Student.calculateFee());
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    }
}