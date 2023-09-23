using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Student : Person
    {
        public string program;
        public int year;
        public double fee;

        public Student(string name, string address,string program, int year, double fee) : base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string getProgram()
        {
            return program;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public void setYear(int year) {
            this.year = year;
        }
        public int getYear()
        {
            return year;
        }
        public void setFee(double fee)
        {
            this.fee = fee;
        }
        public double getFee()
        {
            return fee;
        }
        public override string toString()
        {
            return "Name: " + name + " Address: " + address + " Program: " + program + " Fee: " + fee + " Year: " + year;
        }
    }
}
