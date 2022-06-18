// See https://aka.ms/new-console-template for more information
using PayRollTask;
Salesman sm = new Salesman("Anush","4SN100",40000,5000);
Salesman.GetOrganizationName();
Salesman.walk();
sm.work();

HR hr = new HR("Vinay", "4MN100", 60000, 5000);
HR.GetOrganizationName();
HR.walk();
hr.work();

SoftwareEngineer se = new SoftwareEngineer("Dhanush", "4NN100", 50000, 6000);
SoftwareEngineer.GetOrganizationName();
SoftwareEngineer.walk();
se.work();