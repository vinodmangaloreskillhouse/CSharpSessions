using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal abstract class Armour
    {
        public string Guard { get; set; }

        public string Sword { get; set; }
        public abstract void Fight();
    }
}
