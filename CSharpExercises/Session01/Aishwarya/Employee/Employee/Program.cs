// See https://aka.ms/new-console-template for more information
using Employee;

Employees Employee1 = new Employees("Thomas",56, "Chief Technical Officer","DataMart");
Console.WriteLine("Command: Work or Stand Up");
string v = Console.ReadLine();
Employee1.Command(v);

Employees Employee2 = new Employees("Pinto", 60, "Chief Operating Officer", "QMart");
Console.WriteLine("\nCommand: Work or Stand Up");
string s = Console.ReadLine();
Employee2.Command(s);




