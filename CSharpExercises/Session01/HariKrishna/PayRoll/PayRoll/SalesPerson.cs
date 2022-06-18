using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    internal class SalesPerson : Employee
    {
        public override void basesalary()
        {
            Console.WriteLine("The base salary for Sales Person is Rs.600000");
        }

        public override void bonus()
        {
            Console.WriteLine("The bonus for the Sales Person is Rs.10000");
        }

        public override void work()
        {
            Console.WriteLine("I'm Travelling");
        }
    }
}
