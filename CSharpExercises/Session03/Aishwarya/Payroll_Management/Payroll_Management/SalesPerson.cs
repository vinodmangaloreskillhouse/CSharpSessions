using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Management
{
    internal class SalesPerson:Employee
    {
        public override void Work()
        {
            Console.WriteLine("  I am" + this.Name + " now I am travelling");
        }
        public override void Bonus()
        {
            Console.WriteLine("Bonus amopunt is 9000");
        }
        public override double getSalary()
        {
            return salary;
        }


    }
}
