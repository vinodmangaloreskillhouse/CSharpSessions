using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTask
{
    internal class UserDetails
    {
       public string FirstName;
       public string LastName;
       public string Address;
       public string EmailId;
       public string Password;
       public DateTime dateTime=DateTime.Now;
        public UserDetails(string firstName,string lastName,string address,string emailId,string password)
        {
            FirstName = firstName;
            LastName= lastName;
            Address = address;
            EmailId = emailId;
            Password = password;
        }

    }
}
