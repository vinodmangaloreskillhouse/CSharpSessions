using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProject
{
    internal class Box
    {
        public Box(double heightPassed, double widthPassed, double breadthPassed)
        {
            this.Height = heightPassed;
            this.Width = widthPassed;
            this.Breadth = breadthPassed;
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

    }
}
