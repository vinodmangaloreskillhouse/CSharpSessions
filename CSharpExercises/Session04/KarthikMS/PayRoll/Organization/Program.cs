// See https://aka.ms/new-console-template for more information
using PayRollTask;
Employee.GetOrganizationName = "ABCD.ltd";
Salesman sm = new Salesman();
sm.Name = "Varun";
sm.ID = "4SN101";
sm.BaseSalary = 50000;
sm.Bonus = 5000;
sm.EmployeeDetails();
sm.Walk();
sm.Work();


HR hr = new HR();
hr.Name = "Govind";
hr.ID = "4HR102";
hr.BaseSalary = 65000;
hr.Bonus = 6000;
hr.EmployeeDetails();
hr.Walk();
hr.Work();

SoftwareEngineer se = new SoftwareEngineer();
se.Name = "Anush";
se.ID = "4SE101";
se.BaseSalary = 60000;
se.Bonus = 5500;
se.EmployeeDetails();
se.Walk();
se.Work();