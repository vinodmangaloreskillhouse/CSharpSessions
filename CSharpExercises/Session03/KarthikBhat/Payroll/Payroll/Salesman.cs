using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    internal class Salesman:Employee
    {
        public override void Work()
        {
            Console.WriteLine("Im busy in travelling");
        }
        public override void BaseSalary()
        {
            Console.WriteLine("Base salary for Salesman is 20000");

        }
        public override void Bonus()
        {
            Console.WriteLine("Bonus for Salesman is 1000");
        }

    }
}
