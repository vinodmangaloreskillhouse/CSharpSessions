using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class NameCollection
    {
        List<String> nameList = new List<string>();
        public String Name { get; set; }
       
        public void AddName(String Name)
        {
            nameList.Add(Name);
        }
        public void reverseClone() 
        { 
            var newList = new List<String>();
          for(int i = nameList.Count -1; i >=0 ;i--)
            {
                Console.WriteLine(nameList[i]);
            }
        }
        public  void Display()
        {
            foreach(String Name in nameList)
            {
                Console.WriteLine(Name);
            }
        }
    }
}
