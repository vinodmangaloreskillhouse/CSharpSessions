using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    internal class Person
    {
        string Name { get; set; }
        string Color { get; set; }

        string CountryName;
        int Age { get; set; }

        public Person(string name, string color, string countryName, int Age)
        {
            this.Name = name;
            this.Color = color;
            this.CountryName = countryName;
            this.Age = Age;
        }
        public void Breakfast(string breakfastspecial)
        {

            Console.WriteLine("\nHi..I am " + this.Name + " " + this.Age + " old " + " from " + this.CountryName + " my colour is " + this.Color +
                " and having: " + "\n" + breakfastspecial + " for breakfast");
        }
        public void Lunch(string lunchspecial)
        {

            Console.WriteLine(lunchspecial + " for lunch");

        }
        public void Dinner(string dinnerspecial)
        {

            Console.WriteLine(dinnerspecial + " for dinner");

        }

    }
}
