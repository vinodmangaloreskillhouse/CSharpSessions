using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    internal abstract class Employee
    {   
        public static string OrganisationName { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }

        public abstract void BaseSalary();

        public abstract void Bonus();

        public abstract void Work();

        public void Walk()
        {
            Console.WriteLine("Simply Walking");
        }
        
    }
}
