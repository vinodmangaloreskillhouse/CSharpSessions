using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    internal abstract class Employee
    {
        public string OrganizationName()
        {
            string comapnyName = "XYZ Company";
            return comapnyName;
            //Console.WriteLine("XYZ Company");
        }
        public string Name { get; set; }

        public int EmployeeID { get; set; }

        public double BaseSalary { get; set; }

        public virtual double BonusSalary()
        {
            return 5000.00;
            
        }

        public void Walk()
        {
            Console.WriteLine("I am walking now");
        }
        public abstract void Work();
    }
}
