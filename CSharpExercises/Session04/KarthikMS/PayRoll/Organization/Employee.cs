using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollTask
{
    internal abstract class Employee
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public static string GetOrganizationName { get; set; }
        
        public void EmployeeDetails()
        {
            Console.WriteLine("My name is " + this.Name + ".My employee id is " + this.ID);
        }
        public void Walk()
        {
            Console.WriteLine(" I am walking now");
        }
        public abstract void Work();
      

    }
}
