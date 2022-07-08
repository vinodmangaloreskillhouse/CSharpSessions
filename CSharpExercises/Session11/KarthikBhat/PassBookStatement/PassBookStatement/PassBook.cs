using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassBookStatement
{
    internal class PassBook
    {
        List<Statement> statements = new List<Statement>();

        public void AddEntry(Statement statement)
        {
            statements.Add(statement);
            
        }

        public void  PrintEntries(Statement statement)
        {
             Console.WriteLine("Title: "+statement.Title+" Statement: "+ statement.Description+" Date: "+ statement.Date+" Amount: "+ statement.Amount +" IsAdd: "+statement.IsAdd+" Isdeducted: "+statement.IsDeduction);
        }

       public int Totalentry()
        {
            return statements.Count;
        }

    }
}
