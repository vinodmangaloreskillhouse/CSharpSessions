using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class Cavalry:Armour
    {
        public string Name { get; set; }

        public void RideHourse()
        {
            Console.WriteLine("Rideng Hourse");
        }
        public override void Fight()
        {
           Console.WriteLine("Fight and Ride hourse");
        }
    }
}
