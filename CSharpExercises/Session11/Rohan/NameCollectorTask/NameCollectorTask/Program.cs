// See https://aka.ms/new-console-template for more information

using NameCollectorTask;

NameCollection names = new NameCollection();
names.AddNames("Rohan");
names.AddNames("Vinod");
names.AddNames("Jaideep");

foreach (var name in names.nameList)
    Console.WriteLine(name);

var reversedList = names.ReverseClone();
Console.WriteLine("\nReversed List");
foreach (var name in reversedList)
    Console.WriteLine(name);