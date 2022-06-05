using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Employer
    {
        public string Name { get; set; } 

        public int Age { get; set; }

        public string Company { get; set; }

        public string Designation { get; set; }

        public void Work()
        {
            Console.WriteLine("Hey I am " + this.Name + " I am Working. Thank you.");
        }

        public string StandUp()
        {
            string message = "I am " + this.Age + " years old. How may I help you?";
            return message;
        }
    }
}
