// See https://aka.ms/new-console-template for more information
using Payroll_Management;
SoftwareEngineer se1 = new SoftwareEngineer();
se1.Name = "Aishu";
se1.EmployeeID = 101;
se1.salary = 59000;
se1.Bonus = 5000;
se1.displayDetails();
se1.Walk();
se1.Work();
se1.Bonus = 6000;
Console.WriteLine(se1.getSalary());
Console.WriteLine(SoftwareEngineer.OrganisationName);

HR hr1 = new HR();
hr1.Name = "sush";
hr1.EmployeeID = 102;
hr1.salary = 90000;
hr1.Bonus = 7000;
hr1.displayDetails();
hr1.Walk();
hr1.Work();
hr1.Bonus=9000;
Console.WriteLine(HR.OrganisationName);
Console.WriteLine(hr1.getSalary());


SalesPerson sp1 = new SalesPerson();
sp1.Name = "sudee";
sp1.EmployeeID = 108;
sp1.salary = 50800;
sp1.Bonus = 4000;
sp1.displayDetails();
sp1.Walk();
sp1.Work();
sp1.Bonus=4000;
Console.WriteLine(SalesPerson.OrganisationName);
Console.WriteLine(sp1.getSalary());









