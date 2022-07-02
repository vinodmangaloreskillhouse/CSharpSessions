using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassbookTask
{
    internal class Statement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public Boolean isAdd { get; set; }
        public Boolean isDeducted { get; set; }

    }
}
