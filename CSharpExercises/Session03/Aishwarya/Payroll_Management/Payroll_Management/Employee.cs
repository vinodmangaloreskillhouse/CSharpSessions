using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management
{
    internal  class Employee
    {
        public string Name { get;set; } 
        public int EmployeeID { get; set; }
        public double Bonus { get; set; }
         
        public double salary;

        public static string OrganisationName
        {
            get { return "Nivious_Solution"; }
            set{ }
        }
        
            public void displayDetails()
        {
            Console.WriteLine("I am " + this.Name + " my employee id is " + this.EmployeeID+" and bonus of "+this.Bonus);
        }
          

        public void Walk()
        {
            Console.WriteLine("hey..I am " + this.Name + " now I am walking");
        }
        public virtual void Work()
        {
            Console.WriteLine("I am " + this.Name + " now I am performing my regular tasks");

        }
     
         public  virtual double getSalary()
        {
            return salary;
        }
        
    }
}
