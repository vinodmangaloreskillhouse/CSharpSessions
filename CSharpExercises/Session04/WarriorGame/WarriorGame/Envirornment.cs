using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorGame
{
    internal static  class Envirornment
    {
        public static string AirSpeed { get; set; }

        public static DateTime Date { get; set; }

        public static DateTime Time { get; set; }

        public static  decimal Temp { get; set; }

        public static decimal GetTemp()
        {
            return Temp;
        }
    }
}
