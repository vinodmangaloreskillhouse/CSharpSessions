// See https://aka.ms/new-console-template for more information
using ConsoleAppPerson;

Person p1 = new Person("Lokesh",45,"India");
string Breakfast=p1.Breakfast("Roti");
Console.WriteLine(Breakfast);
string Lunch=p1.Lunch("South Indian Thali");
Console.WriteLine(Lunch);
string Dinner=p1.Dinner("Chapathi");
Console.WriteLine(Dinner);

Person p2 = new Person("Tom",50,"USA");
string Breakfast2=p2.Breakfast("Salad");
Console.WriteLine(Breakfast2);
string Lunch2=p2.Lunch("Burger");
Console.WriteLine(Lunch2);
string Dinner2 =p2.Dinner("Egg Sandwich");
Console.WriteLine(Dinner2);



