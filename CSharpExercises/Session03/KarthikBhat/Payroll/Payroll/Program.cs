// See https://aka.ms/new-console-template for more information
using Payroll;

Employee.OrganisationName = "KarthikLTD";

SoftwareEngineering softwareEngineering = new SoftwareEngineering();
softwareEngineering.Name = "Karthik";
softwareEngineering.Id = 100;
softwareEngineering.BaseSalary = 2000000;
softwareEngineering.Bonus = 100000;
Console.WriteLine("Name: " + softwareEngineering.Name + " ID: " + softwareEngineering.Id + " Base Salary: " + softwareEngineering.BaseSalary + " Bonus: " + softwareEngineering.Bonus);
Console.WriteLine("Company name: " + SoftwareEngineering.OrganisationName);
softwareEngineering.Walk();
softwareEngineering.Work();


Salesman salesman = new Salesman();
salesman.Name = "Krish";
salesman.Id = 200;
salesman.BaseSalary = 100000;
salesman.Bonus = 2050;
Console.WriteLine("Name: " + salesman.Name + " ID: " + salesman.Id +  " Base Salary: " + salesman.BaseSalary + " Bonus: " + salesman.Bonus);
Console.WriteLine("Company name: "+Salesman.OrganisationName);
salesman.Walk();
salesman.Work();


HR hr =new HR();
hr.Name = "Vishwa";
hr.Id = 500;
hr.BaseSalary = 350000;
hr.Bonus = 60000;
Console.WriteLine("Name: " + hr.Name + " ID: " + hr.Id +  " Base Salary: " + hr.BaseSalary + " Bonus: " + hr.Bonus);
Console.WriteLine("Company Name: "+HR.OrganisationName);
hr.Walk();
hr.Work();

