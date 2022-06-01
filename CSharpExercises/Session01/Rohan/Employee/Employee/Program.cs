// See https://aka.ms/new-console-template for more information

using Employee;

Employees employee1 = new Employees();
employee1.Name = "Thomas";
employee1.Age = 56;
employee1.Company = "DataMart";
employee1.Designation = "Chief Technical Officer";

Console.WriteLine("Name:        "+employee1.Name);
Console.WriteLine("Age:         "+employee1.Age);
Console.WriteLine("Company:     "+employee1.Company);
Console.WriteLine("Designation: "+employee1.Designation);

Console.WriteLine("\nEnter an instruction (Work/Stand)");
var Instruct=Console.ReadLine();
employee1.Instrution = Instruct;
if(employee1.Instrution == "Work")
{
    Console.WriteLine("\nHey I am " + employee1.Name + ". I am working! Thank you");
}
else if (employee1.Instrution == "Stand" || employee1.Instrution=="stand")
{
    Console.WriteLine("\nI am 56 years old. How may I help you?");
}

Employees employee2 = new Employees();
employee2.Name = "Pinto";
employee2.Age = 60;
employee1.Company = "QMart";
employee1.Designation = "Chief Operating Officer";

Console.WriteLine("\nName:      " + employee1.Name);
Console.WriteLine("Age:         " + employee1.Age);
Console.WriteLine("Company:     " + employee1.Company);
Console.WriteLine("Designation: " + employee1.Designation);

Console.WriteLine("\nEnter an instruction (Work/Stand)");
var Instructs = Console.ReadLine();
employee1.Instrution = Instructs;
if (employee1.Instrution == "Work")
{
    Console.WriteLine("\nHey I am "+employee2.Name+". I am working! Thank you");
}
else if (employee1.Instrution == "Stand" || employee1.Instrution == "stand")
{
    Console.WriteLine("\nI am "+employee2.Age+" years old. How may I help you?");
}
