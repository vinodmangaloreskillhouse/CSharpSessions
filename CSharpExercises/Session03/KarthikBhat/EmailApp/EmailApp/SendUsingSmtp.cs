using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailApp
{
    internal class SendUsingSmtp:Test, ISendEmail
    {
       

        public void send()
        {
            Console.WriteLine("Sending using SMTP");
        }

        public void Delete()
        {
            Console.WriteLine("Deleting using SMTP");
        }
    }
}
