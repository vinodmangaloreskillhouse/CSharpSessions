// See https://aka.ms/new-console-template for more information
using PassBookDetails;
Statement statement1 = new Statement();
statement1.Title = "Credit";
statement1.Description = "Deposit from Credit Card Processor ";
statement1.Date = DateTime.Now;
statement1.Amount = 15000;
statement1.IsAdd = true;
statement1.IsDeduction = false;

Statement statement2 = new Statement();
statement2.Title = "Debit";
statement2.Description = "Bill Paid";
statement2.Date = DateTime.Now;
statement2.Amount = 5000;
statement2.IsAdd = false;
statement2.IsDeduction = true;

PassBook book = new PassBook();
book.AddEntry(statement1);
book.AddEntry(statement2);
book.PrintEntries(statement1);
book.PrintEntries(statement2);

Console.WriteLine("Total Entries are: " + book.TotalEntries());
