using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollTask
{
    internal class Salesman : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Im travelling");
        }
    }
}
