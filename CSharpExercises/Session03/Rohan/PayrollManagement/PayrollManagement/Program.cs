// See https://aka.ms/new-console-template for more information

using PayrollManagement;

HR hr = new HR();
var HRName1=hr.Name="Vinod";
var HRId1 = hr.EmployeeID = 101;
var HRbaseSalary = hr.BaseSalary = 30000;
var HRbonusSalary = hr.BonusSalary = 20000;

Console.WriteLine("\nHey I am {0}, I work as an HR in {1} " +
    "\nThis is my Employee Id: {2} ",HRName1, Employee.OrganizationName,HRId1);
Console.WriteLine("My base salary is: {0}, I get a bonus of {1}", HRbaseSalary, HRbonusSalary);
hr.Walk();

SalesPerson sp=new SalesPerson();
var SPName1 = sp.Name = "Arun";
var SPId1 = sp.EmployeeID = 102;
var SPbaseSalary = sp.BaseSalary = 20000;
var SPbonusSalary = sp.BonusSalary = 15000;

Console.WriteLine("\nHey I am {0}, I work as an Sales Person in {1} " +
    "\nThis is my Employee Id: {2} ",SPName1, Employee.OrganizationName, SPId1);
Console.WriteLine("My base salary is: {0}, I get a bonus of {1}", SPbaseSalary, SPbonusSalary);
sp.Walk();

SoftwareEngineer se=new SoftwareEngineer();
var SEName1 = se.Name = "Rohan";
var SEId1 = se.EmployeeID = 103;
var SEbaseSalary = se.BaseSalary = 80000;
var SEbonusSalary = se.BonusSalary = 30000;

Console.WriteLine("\nHey I am {0}, I work as an Software Engineer in {1} " +
    "\nThis is my Employee Id: {2} ", SEName1, Employee.OrganizationName, SEId1);
Console.WriteLine("My base salary is: {0}, I get a bonus of {1}", SEbaseSalary, SEbonusSalary);
se.Walk();