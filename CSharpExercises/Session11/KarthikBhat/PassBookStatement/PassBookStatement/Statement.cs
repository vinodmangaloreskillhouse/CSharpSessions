using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassBookStatement
{
    internal class Statement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public bool IsAdd { get; set; }
        public bool IsDeduction { get; set; }
    }
}
