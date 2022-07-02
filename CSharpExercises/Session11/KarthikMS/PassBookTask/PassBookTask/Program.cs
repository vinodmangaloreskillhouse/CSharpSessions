// See https://aka.ms/new-console-template for more information
using PassBookTask;

Statement statement1= new Statement( );
statement1.Title = "abc";
statement1.Description = "def";
statement1.Amount = 500.00f;
statement1.Date = DateTime.Now;
statement1.IsAdd = true;
statement1.IsDeduction = false;

Statement statement2 = new Statement();
statement2.Title = "xyz";
statement2.Description = "pqr";
statement2.Amount = 200.50f;
statement2.Date = DateTime.Now;
statement2.IsAdd = true;
statement2.IsDeduction = true;

PassBook passbook = new PassBook();
passbook.AddEntry(statement1);
passbook.PrintEntries(statement1);
passbook.AddEntry(statement2);
passbook.PrintEntries(statement2);
passbook.TotalEntries(statement2);
