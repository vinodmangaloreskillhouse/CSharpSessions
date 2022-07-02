// See https://aka.ms/new-console-template for more information
using Collection;

NameCollection names = new NameCollection();

names.AddName("Lokesh");
names.AddName("Chirag");
names.AddName("Bharath");
Console.WriteLine("Names are :");
names.Display();
Console.WriteLine("Names are in reverse order :");
names.reverseClone();


