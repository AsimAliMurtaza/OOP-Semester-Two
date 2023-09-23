using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne.BL
{
    internal class Employee
    {
        public string name;
        public string rank;
        public int age;
        public string phone;

        public Employee(string name, string rank, int age, string phone)
        {
            this.name = name;
            this.rank = rank;
            this.age = age;
            this.phone = phone;
        }
    }
}
