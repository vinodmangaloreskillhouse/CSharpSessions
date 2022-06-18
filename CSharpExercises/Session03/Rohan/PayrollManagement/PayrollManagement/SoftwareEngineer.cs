using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    internal class SoftwareEngineer:Employee
    {
        public override void Work()
        {
            Console.WriteLine("Hey, I am Developing");
        }

        public override double BonusSalary()
        {
            double bonus = 50000;
            return bonus;
        }
    }
}
