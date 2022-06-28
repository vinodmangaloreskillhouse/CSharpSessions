using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    internal class people
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Food { get; set; }

        public people (String name,int age,String country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }
        public string Breakfast(string Food)
        {
            this.Food = Food;
            string message = this.Name + "'s Breakfast is " + this.Food;
            return message;
        }
        public string Lunch(string Food)
        {
            this.Food = Food;
            string message = this.Name + "'s Lunch is "+ this.Food;
            return message;
        }
        public string Dinner(string Food)
        {
            this.Food= Food;
            string message = this.Name + "'s Dinner is "+ this.Food;
            return message;
        }
    }


}
   

