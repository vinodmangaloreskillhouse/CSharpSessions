using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IEmployee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string GetName();

        public void Walk();
    }
}
