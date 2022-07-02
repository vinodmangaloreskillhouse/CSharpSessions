using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassBookDetails
{
    internal class PassBook
    {
        List<Statement> statements = new List<Statement>();
        public void AddEntry(Statement statement)
        {
            statements.Add(statement);
        }
        public void PrintEntries(Statement statement)
        {
            Console.WriteLine("\nTitle: " + statement.Title + "\nStatement: " + statement.Description + "\nDate: " + statement.Date + "\nAmount:" + statement.Amount + "\nIsAdd: " + statement.IsAdd + "\nIsDeducted: " + statement.IsDeduction);
        }
        public int TotalEntries()
        {
           return statements.Count;
        }
            
    }
}
