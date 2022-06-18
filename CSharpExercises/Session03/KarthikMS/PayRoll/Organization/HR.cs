using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRollTask
{
    internal class HR
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public HR(string Name, string ID, decimal BaseSalary, decimal Bonus)
        {
            this.Name = Name;
            this.ID = ID;
            this.BaseSalary = BaseSalary;
            this.Bonus = Bonus;
            Console.WriteLine("HR Details");
            Console.WriteLine("Name:" + this.Name + "\nID:" + this.ID + "\nBaseSalary:" + this.BaseSalary + "\nBonus:" + this.Bonus);
        }
        public static void GetOrganizationName()
        {
            Console.WriteLine("My Organization name is ABCD");
        }
        public void work()
        {
            Console.WriteLine("Im hiring the new employees");
        }
        public static void walk()
        {
            Console.WriteLine("Im walking");
        }
    }
}
