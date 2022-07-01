using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll
{
    internal abstract class Employee
    {

        public string name { get; set; }

        public int ID { get; set; }

        public abstract void basesalary();

        public abstract void bonus();

        public abstract void work();

        public void walk()
        {
            Console.WriteLine("I'm Simply Walking");
        }

    }
}
