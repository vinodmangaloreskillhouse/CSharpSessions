﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPeople
{
    internal class People
    {
        

        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string Colour { get; set; }
        public string Food { get; set; }

        public People(String name, int age, string colour, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
            this.Colour = colour;
            Console.WriteLine("Person name is " + this.Name +" and he is "+this.Age+ " year old and his skin colour is "+this.Colour+" and he belong to "+this.Country+ " .");
        }
        public string Breakfast(string Food)
        {
            this.Food = Food;
            string message =this.Name  +" 's Breakfast is " + this.Food;
            return message;
            

        }
        public string Lunch(string Food)
        {
            this.Food = Food;
            string message = this.Name+" 's Lunch is " + this.Food;
            return message;


        }
        public string Dinner(string Food)
        {
            this.Food = Food;
            string message = this.Name+" 's Dinner is " + this.Food;
            return message;


        }


        /*public string Lunch()
        {
            if (Country == "India")
            {
                return "Lunch is Pulav";
            }
            else if (Country == "USA")
            {
              return  "Lunch is ";
            }
        }
        public string Dinner()
        {
            if (Country == "India") {
                return "Dinner is ";
            }
            else if (Country == "USA")
            {
               return "Dinner is ";
            }
        }*/

    } }