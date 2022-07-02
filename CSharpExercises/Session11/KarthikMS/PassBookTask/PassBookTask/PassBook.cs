using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassBookTask
{
    internal class PassBook
    {
        List<Statement> statements =new List<Statement>();
       
        public void AddEntry(Statement statement)
        {
            statements.Add(statement);
        }
        public void PrintEntries(Statement statement)
        {   
                Console.WriteLine(statement.Title+ "\n" +statement.Description+ "\n"+ statement.Amount+ "\n" + statement.Date+ "\n" + statement.IsAdd+ "\n" + statement.IsDeduction);   
        }
        public void TotalEntries(Statement statement)
        {
            int Length = statements.Count;
            Console.WriteLine("Length of the statements "+Length);
        }
    }
}
