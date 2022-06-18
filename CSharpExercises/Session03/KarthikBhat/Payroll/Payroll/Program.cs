// See https://aka.ms/new-console-template for more information
using Payroll;

Employee.OrganisationName = "KarthikLTD";

SoftwareEngineering softwareEngineering = new SoftwareEngineering();
softwareEngineering.Name = "Karthik";
softwareEngineering.Id = 100;
softwareEngineering.Walk();
softwareEngineering.Work();
softwareEngineering.BaseSalary();
softwareEngineering.Bonus();

Salesman salesman = new Salesman();
salesman.Name = "Krish";
salesman.Id = 200;
salesman.Walk();
salesman.Work();
salesman.BaseSalary();
salesman.Bonus();

HR hr=new HR();
hr.Name = "Vishwa";
hr.Id = 500;
hr.Walk();
hr.Work();
hr.BaseSalary();
hr.Bonus();

