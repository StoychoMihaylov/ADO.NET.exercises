using PeopleProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleDBContext context = new PeopleDBContext();
            try
            {
                Person person = new Person();
                person.FirstName = "gosho";
                context.People.Add(person);
                context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult dbEntityValidationResult in ex.EntityValidationErrors)
                {
                    foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        Console.WriteLine(dbValidationError.ErrorMessage);
                    }
                }
            }
        }
    }
}
