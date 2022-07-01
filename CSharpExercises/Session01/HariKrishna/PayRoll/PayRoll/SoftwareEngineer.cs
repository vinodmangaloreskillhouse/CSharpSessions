using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    internal class SoftwareEngineering : Employee
    {
        public override void basesalary()
        {
            Console.WriteLine("The base salary for Software Engineer is Rs.250000");
        }

        public override void bonus()
        {
            Console.WriteLine("The bonus for the Software Engineer is Rs.50000");
        }

        public override void work()
        {
            Console.WriteLine("I'm Coding");
        }
    }
}
