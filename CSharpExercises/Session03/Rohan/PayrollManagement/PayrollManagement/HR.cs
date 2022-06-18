using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagement
{
    internal class HR : Employee
    {
        
        public override void Work()
        {
            Console.WriteLine("Hey, I am Recruting");
        }

        public override double BonusSalary()
        {
            double bonus= 15000;
            return bonus;
           
        }
    }
}
