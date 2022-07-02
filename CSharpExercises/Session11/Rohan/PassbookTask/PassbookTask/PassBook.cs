using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassbookTask
{
    internal class PassBook
    {
        List<Statement> statements = new List<Statement>();

        public void AddEntry()
        {
            statements.Add(new Statement { Title ="Food", Description = "Lunch", Date = DateTime.Now, Amount = 455.78, isAdd = false, isDeducted = true });
            statements.Add(new Statement { Title = "Salary", Description = "Work", Date = DateTime.Now, Amount = 45756.9, isAdd = true, isDeducted = false });
            statements.Add(new Statement { Title = "Grocery", Description = "House", Date = DateTime.Now, Amount = 1109.8, isAdd = false, isDeducted = true });

        }
        public void PrintEntries()
        {
            foreach (Statement s in statements)
            {
                Console.WriteLine("Title: {0} Description: {1} Date: {2} Amount: {3} IsAdded: {4} IsDeducted: {5} ", s.Title, s.Description, s.Date, s.Amount, s.isAdd,s.isDeducted);
            }
        }
        public void TotalEntries()
        {
            Console.WriteLine("\nTotal Entries: {0}",statements.Count);
        }
    }
}
