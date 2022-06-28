using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employee
    {
        public string Name;
        public int Age;
        public string JobRole;
        public string companyName;
      
        public Employee(string name, int age, string jobRole, string company)
        {
            this.Name = name;
            this.Age = age;
            this.JobRole = jobRole;
            this.companyName = company;


        }
        public void Work()
        {
            Console.WriteLine("Hey I am " + this.Name + " I am working as " + this.JobRole + " at " + this.companyName + " Thank you..");
        }
         public void standUp()
        {
          
            Console.WriteLine("I am " + this.Age + " years old. How may I help you?");

        }
    
       
    }
}
