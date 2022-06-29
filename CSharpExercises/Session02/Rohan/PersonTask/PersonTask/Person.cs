using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
    internal class Person
    {
        int Age;
        string Name, Country;
        public Person(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public void Breakfast(string breakfastItem)
        {
            string BreakfastItem = breakfastItem;
            Console.WriteLine("\nHi,I am " + this.Name + " I am from " + this.Country + " I had " + BreakfastItem + " for breakfast");
        }

        public string Lunch(string lunchItem)
        {
            string LunchItem = lunchItem;
            Console.WriteLine("I had " + lunchItem + " for lunch");
            return null;
        }

        public string Dinner(string dinnerItem)
        {
            string DinnerItem = dinnerItem;
            //Console.WriteLine("I had "+DinnerItem+" for dinner");
            return DinnerItem;
        }
    }
}