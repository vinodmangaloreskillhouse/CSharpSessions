using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp
{
    internal class SendUsingSendGrid:Test,ISendEmail
    {

        
        public void send()
        {
            Console.WriteLine("Sending using Send Grid");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting using Send Grid");
        }
    }
}
