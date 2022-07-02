using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassBookDetails
{
    internal class Statement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public Boolean IsAdd { get; set; }
        public Boolean IsDeduction { get; set; }

    }
}
