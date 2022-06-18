using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    internal class SalesPerson:Employee
    {
        public override void Work()
        {
            Console.WriteLine("Hey, I am Selling Items");
        }

        public override double BonusSalary()
        {
            double bonus = 10000;
            return bonus;
        }
    }
}
