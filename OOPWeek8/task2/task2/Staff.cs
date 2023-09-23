using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Staff : Person
    {
        protected string school;
        protected double pay;

        public Staff(string name, string address, string school, double pay):base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }
        public string getSchool()
        {
            return school;
        }
        public double getPay()
        {
            return pay;
        }
        public void setSchool(string school)
        {
            this.school = school;
        }
        public void setPay(double pay)
        { this.pay = pay; }
        public override string toString()
        {
            return "Name: " + name + " Address: " + address + " School" + school + " Pay: " + pay;
        }
    }
}
