// See https://aka.ms/new-console-template for more information
using Employee;

Employee.Employee Employee1 = new Employee.Employee("Thomas",56, "Chief Technical Officer","DataMart");
Console.WriteLine();
Console.WriteLine("\nCommand: work");
Employee1.Work();
Console.WriteLine("Command: StandUp");
Employee1.standUp();

Employee.Employee Employee2 = new Employee.Employee("Pinto", 60, "Chief Operating Officer", "QMart");
Console.WriteLine("\nCommand: Work");
Employee2.Work();
Console.WriteLine("Command: StandUp");
Employee2.standUp();





