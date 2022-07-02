using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameCollectorTask
{
    internal class NameCollection
    {
        public List<string> nameList = new List<string>();
        public void AddNames(string name)
        {
            nameList.Add(name);
        }

        public List<string> ReverseClone()
        {
            var newList = new List<string>();
            for (int i = nameList.Count() - 1; i >= 0; i--)
                newList.Add(nameList[i]);
            /*foreach (string name in nameList)
                newList.Add(name);
            newList.Reverse();*/
            return newList;
        }
    }
}