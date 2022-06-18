using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    internal  class SoftwareEngineering:Employee
    {

        public override  void Work()
        {
            Console.WriteLine("Im busy in coding");
        }
        public override void BaseSalary()
        {
            Console.WriteLine("Base salary for SE is 150000");

        }
        public override void Bonus()
        {
            Console.WriteLine("Bonus for SE is 20000");
        }

    }
}
