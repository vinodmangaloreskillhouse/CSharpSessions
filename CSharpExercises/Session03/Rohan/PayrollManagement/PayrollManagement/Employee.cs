using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    internal abstract class Employee
    {
        public static string OrganizationName 
        { 
            get => "XYZ Company";
            set { }
         }
        public string Name { get; set; }

        public int EmployeeID { get; set; }

        public double BaseSalary { get; set; }

        public double BonusSalary { get; set; }

        public void Walk()
        {
            Console.WriteLine("I am walking now");
        }
        public abstract void Work();
    }
}
