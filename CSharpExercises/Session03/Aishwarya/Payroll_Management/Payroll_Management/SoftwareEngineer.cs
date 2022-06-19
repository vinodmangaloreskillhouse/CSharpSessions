using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management
{
    internal class SoftwareEngineer:Employee
    {
        public override void Work()
        {
            Console.WriteLine("  I am "+this.Name+" now  I am coding");
        }
       
        public override double getSalary()
        {
            return salary;
        }


    }
}
