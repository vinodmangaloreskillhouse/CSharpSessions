using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal class Infantory:Armour
    {
        public string Name { get; set; }

        public void Crawl()
        {
            Console.WriteLine("Only Crawl");
        }

        public override void Fight()
        {
            Console.WriteLine("Fight and Crawl");
        }

        public static string SkyColour { get; set; }    
        public static string GetWeather()
        {
            return "it is raining";
        }
    }
}
