using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    internal class HR:Employee
    {
        public override void Work()
        {
            Console.WriteLine("Im busy in Hiring People");
        }
        public override void BaseSalary()
        {
            Console.WriteLine("Base salary for HR is 3000000");

        }
        public override void Bonus()
        {
            Console.WriteLine("Bonus for Hr is 3600");
        }
    }
}
