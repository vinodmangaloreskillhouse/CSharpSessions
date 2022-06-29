// See https://aka.ms/new-console-template for more information

using Employee;

Employer employee1 = new Employer();
employee1.Name = "Thomas";
employee1.Age = 56;
employee1.Company = "DataMart";
employee1.Designation = "Chief Technical Officer";

Console.WriteLine("Name:        "+employee1.Name);
Console.WriteLine("Age:         "+employee1.Age);
Console.WriteLine("Company:     "+employee1.Company);
Console.WriteLine("Designation: "+employee1.Designation);

employee1.Work();
string message1=employee1.StandUp();
Console.WriteLine(message1);


Employer employee2 = new Employer();
employee2.Name = "Pinto";
employee2.Age = 60;
employee2.Company = "QMart";
employee2.Designation = "Chief Operating Officer";

Console.WriteLine("\nName:      " + employee2.Name);
Console.WriteLine("Age:         " + employee2.Age);
Console.WriteLine("Company:     " + employee2.Company);
Console.WriteLine("Designation: " + employee2.Designation);

employee2.Work();
employee2.StandUp();
string message2 = employee2.StandUp();
Console.WriteLine(message2);
