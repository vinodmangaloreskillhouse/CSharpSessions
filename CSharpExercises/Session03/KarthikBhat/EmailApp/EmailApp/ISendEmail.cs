using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp
{
    internal interface ISendEmail
    {
        public string To { get; set; }
        public string From { get; set; }

        public string Subject { get; set; }

        public void send();

        public void Delete();
        
    }
}
