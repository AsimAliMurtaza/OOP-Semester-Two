using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class StaffUI
    {
        public static Staff getStaffInput()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter adderss");
            string address = Console.ReadLine();
            Console.WriteLine("Enter School: ");
            string school = Console.ReadLine();
            Console.WriteLine("Enter pay");
            double pay = double.Parse(Console.ReadLine());
            
            Staff s = new Staff(name, address, school, pay);   
            return s;
        }
    }
}
