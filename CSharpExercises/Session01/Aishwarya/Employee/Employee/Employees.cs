using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employees
    {
        public string Name;
        public int Age;
        public string JobRole;
        public string Company;
        public string command;
        public Employees(string name, int age, string jobRole, string company)
        {
            this.Name = name;
            this.Age = age;
            this.JobRole = jobRole;
            this.Company = company;


        }
        public void Command(string s)
        {

            this.command = s;
            if(command=="Work")
                Console.WriteLine("Hey I am " + this.Name + " I am working as "+this.JobRole+" at "+this.Company+ " Thank you..");
            else if(command=="StandUp")
                Console.WriteLine("I am " + this.Age + " years old. How may I help you?");
        }
       
    }
}
