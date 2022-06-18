// See https://aka.ms/new-console-template for more information

using PayrollManagement;

HR hr = new HR();
var HRName1=hr.Name="Vinod";
var HRId1 = hr.EmployeeID = 101;
var HRbaseSalary = hr.BaseSalary = 30000;

Console.WriteLine("\nHey I am {0}, I work as an HR in {1} \nThis is my Employee Id: {2} ",HRName1, hr.OrganizationName(),HRId1);
Console.WriteLine("My base salary is: {0}, I get a bonus of {1}", HRbaseSalary, hr.BonusSalary());
hr.Walk();

SalesPerson sp=new SalesPerson();
var SPName1 = sp.Name = "Arun";
var SPId1 = sp.EmployeeID = 102;
var SPbaseSalary = sp.BaseSalary = 20000;

Console.WriteLine("\nHey I am {0}, I work as an HR in {1} \nThis is my Employee Id: {2} ",SPName1, sp.OrganizationName(), SPId1);
Console.WriteLine("My base salary is: {0}, I get a bonus of {1}", SPbaseSalary, sp.BonusSalary());
sp.Walk();

SoftwareEngineer se=new SoftwareEngineer();
var SEName1 = se.Name = "Rohan";
var SEId1 = se.EmployeeID = 103;
var SEbaseSalary = se.BaseSalary = 80000;

Console.WriteLine("\nHey I am {0}, I work as an HR in {1} \nThis is my Employee Id: {2} ", SEName1, se.OrganizationName(), SEId1);
Console.WriteLine("My base salary is: {0}, I get a bonus of {1}", SEbaseSalary, se.BonusSalary());
se.Walk();