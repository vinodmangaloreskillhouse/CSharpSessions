// See https://aka.ms/new-console-template for more information

using PersonTask;

Person person1 = new Person("Rohan", 34, "India");
person1.Breakfast("Idli");
person1.Lunch("Indian Thali");
string m = person1.Dinner("Biriyani");
Console.WriteLine("I had " + m + " for dinner");


Person person2 = new Person("David", 35, "USA");
person2.Breakfast("Salad");
person2.Lunch("Pizza");
string n = person1.Dinner("Steaks");
Console.WriteLine("I had " + n + " for dinner");
