using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the Gringotts database. Write a program that prints all unique wizard first
            //letters of their first names only if they have deposit of type Troll Chest.
            //Order them alphabetically.Use DISTINCT for uniqueness.

           GringottsContext context = new GringottsContext();
            using (context)
            {
                IEnumerable<string> wizzard = context.WizzardDeposits.
                    Where(x => x.DepositGroup == "Troll Chest")
                    .Select(depossit => depossit.FirstName.Substring(0,1))
                    .OrderBy(x => x)
                    .Distinct();
                   
                foreach (var letter in wizzard)
                {
                    Console.WriteLine(letter);
                }
            }
        }
    }
}
