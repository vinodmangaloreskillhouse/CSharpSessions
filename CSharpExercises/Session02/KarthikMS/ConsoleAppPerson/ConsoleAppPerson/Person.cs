using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPerson
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string FoodItem { get; set; }
        
        public Person(string Name,int Age,string Country)
        {
            this.Name = Name;
            this.Age = Age; 
            this.Country = Country;
            Console.WriteLine("Hi! I'm " + this.Name + " I'm " + this.Age + " year old and " + " I'm from " + this.Country);

        }
        public string Breakfast(string FoodItem)
        {
            this.FoodItem = FoodItem;

            string message = "I had breakfast and I ate " +FoodItem;
            return message;
        }
        public string Lunch(string FoodItem)
        {
            this.FoodItem = FoodItem;

            string message ="I had lunch and I ate "+FoodItem ;
            return message;

        }
        public string Dinner(string FoodItem)
        {
            this.FoodItem = FoodItem;
            string message ="I had dinner and I ate " +FoodItem ;
            return message;
        }
    }
}
