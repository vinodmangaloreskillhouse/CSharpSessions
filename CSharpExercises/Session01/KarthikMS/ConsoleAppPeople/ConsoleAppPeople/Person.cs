using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPeople
{
    internal class Person
    {
      public  string Name { get; set; }
      public int Age { get; set; }
      public string Country { get; set; }
      public string BreakfastFood { get; set; }
      public string LunchFood { get; set; }
      public string DinnerFood { get; set; }
      public void Breakfats()
        {
            Console.WriteLine("Hi! I'm " +this.Name +" I'm "+this.Age +" year old and "+" I'm from "+this.Country);
            Console.WriteLine("I had breakfast and I ate " +this.BreakfastFood);
        }
       public void Lunch()
        {
            Console.WriteLine("I had lunch and I ate " +this.LunchFood);

        }
        public void Dinner()
        {
            Console.WriteLine("I had dinner and I ate " +this.DinnerFood);

        }
    }
}
