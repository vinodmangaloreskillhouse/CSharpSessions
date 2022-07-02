// See https://aka.ms/new-console-template for more information
using PassBookStatement;
Statement statement1 = new Statement();
statement1.Title = "Adding";
statement1.Description = "Goutham";
statement1.Date = DateTime.Now;
statement1.Amount = 1000;
statement1.IsAdd = true;
statement1.IsDeduction = false;

Statement statement2=new Statement();
statement2.Title = "Deduction";
statement2.Description = "karthik";
statement2.Date = DateTime.Now;
statement2.Amount = 200000;
statement2.IsAdd =false;
statement2.IsDeduction = true;

PassBook pass = new PassBook();
pass.AddEntry(statement1);
pass.AddEntry(statement2);
pass.PrintEntries(statement1);
pass.PrintEntries(statement2);

Console.WriteLine("Total number of Entry are: "+pass.Totalentry());