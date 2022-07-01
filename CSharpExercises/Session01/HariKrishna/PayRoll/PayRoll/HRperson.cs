using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    internal class HRperson : Employee
    {
        public override void basesalary()
        {
            Console.WriteLine("The base salary for HR Person is Rs.7000000");
        }

        public override void bonus()
        {
            Console.WriteLine("The bonus for the HR Person is Rs.80000");
        }

        public override void work()
        {
            Console.WriteLine("I'm Hiring");
        }
    }
}
