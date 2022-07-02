using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassBookTask
{
    public class Statement
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public Boolean IsAdd { get; set; }
        public Boolean IsDeduction { get; set; }

    }
}
