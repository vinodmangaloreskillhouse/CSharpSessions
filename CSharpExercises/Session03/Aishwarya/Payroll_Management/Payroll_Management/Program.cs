// See https://aka.ms/new-console-template for more information
using Payroll_Management;
SoftwareEngineer se1 = new SoftwareEngineer();
se1.Name = "Aishu";
se1.EmployeeID = 101;
se1.salary = 59000;
Employee.OrganisationName = "Wipro";
se1.displayDetails();
se1.Walk();
se1.Work();
se1.Bonus();
Console.WriteLine(se1.getSalary());

HR hr1 = new HR();
hr1.Name = "sush";
hr1.EmployeeID = 102;
hr1.salary = 90000;
Employee.OrganisationName = "Wipro";
hr1.displayDetails();
hr1.Walk();
hr1.Work();
hr1.Bonus();
Console.WriteLine(hr1.getSalary());


SalesPerson sp1 = new SalesPerson();
sp1.Name = "sudee";
sp1.EmployeeID = 108;
sp1.salary = 5000;
Employee.OrganisationName = "Wipro";
sp1.displayDetails();
sp1.Walk();
sp1.Work();
sp1.Bonus();
Console.WriteLine(sp1.getSalary());









