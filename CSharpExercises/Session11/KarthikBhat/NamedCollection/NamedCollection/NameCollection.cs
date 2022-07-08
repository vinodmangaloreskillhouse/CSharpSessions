using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedCollection
{
    internal class NameCollection
    {
        List<string> nameList = new List<string>();

        public void AddName(string name)
        {
            nameList.Add(name);
        }
        public void ReverseClone()
        {
            var newList = new List<string>();


            for (int i = nameList.Count() - 1; i >= 0; i--)
            {
                newList.Add(nameList[i]);
            }

            foreach (string name in newList)
            {
                Console.WriteLine(name);
            }
        }
    }

}
