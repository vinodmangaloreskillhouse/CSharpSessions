﻿// See https://aka.ms/new-console-template for more information


using ConsoleAppPeople;

People people1 = new People("Mohan",50,"Black","India");
string breakfast1=people1.Breakfast("Idli");
Console.WriteLine(breakfast1);
string lunch1 = people1.Lunch("Pulav");
Console.WriteLine(lunch1);
string dinner1 = people1.Dinner("Curd Rice");
Console.WriteLine(dinner1);


People people2 = new People("Thomas", 22, "White", "USA");
string breakfast2 = people2.Breakfast("Bread");
Console.WriteLine(breakfast2);
string lunch2 = people2.Lunch("Pizza");
Console.WriteLine(lunch2);
string dinner2 = people2.Dinner("Sandwich");
Console.WriteLine(dinner2);



