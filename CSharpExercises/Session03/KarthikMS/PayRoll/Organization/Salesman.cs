using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollTask
{
    internal class Salesman
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public Salesman(string Name,string ID,decimal BaseSalary,decimal Bonus)
        {
            this .Name = Name;
            this.ID = ID;
            this .BaseSalary = BaseSalary;
            this .Bonus = Bonus;
            Console.WriteLine("Saleman Details");
            Console.WriteLine("Name:"+this.Name+"\nID:"+this.ID+ "\nBaseSalary:"+this.BaseSalary+"\nBonus:"+this.Bonus);
        }
        public  static void GetOrganizationName()
        {
            Console.WriteLine("My Organization name is ABCD");
        }
        public void work()
        {
            Console.WriteLine("Im travelling");
        }
        public static void walk()
        {
            Console.WriteLine("Im walking");
        }
    }
}
