using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    internal class Box
    {
        public Box()
        {
            //Constructor
            //Can execute any logic when object gets created
            Console.WriteLine("Object Created");
        }
        public double Height { get; set; }

        public double Width { get; set; }

        public double Breadth { get; set; }
    }
}
