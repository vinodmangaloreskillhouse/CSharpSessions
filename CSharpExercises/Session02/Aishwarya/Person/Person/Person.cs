using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTask
{
     internal class Person
    {
        string Name;
        string Color;
        string countryName;
        int Age;
        string breakfastSpecial;
        string lunchSpecial;
        string dinnerSpecial;
        string s;
        
        public Person(string name, string color, string countryName,int Age)
        {
            this.Name = name;
            this.Color = color;
            this.countryName = countryName;
            this.Age = Age;
        }
        public void Breakfast(string s)
        {
            breakfastSpecial= s;
            Console.WriteLine("\nHi..I am "+this.Name+" "+this.Age+" old "+" from "+this.countryName+" my colour is "+this.Color+
                " and having: "+"\n"+this.breakfastSpecial+" for breakfast");
        }
        public string Lunch(string x)
        {
            lunchSpecial= x;
            Console.WriteLine( this.lunchSpecial + " for lunch");
            return null;
        }
        public void Dinner(string s)
        {
            dinnerSpecial= s;
            Console.WriteLine(this.dinnerSpecial + " for dinner");
            
        }
        
    }
}
