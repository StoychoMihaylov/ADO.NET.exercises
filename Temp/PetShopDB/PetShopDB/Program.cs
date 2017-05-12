using PetShopDB.Models;
using System;
using System.Data.Entity.Validation;

namespace PetShopDB
{
    class Program
    {
        static void Main(string[] args)
        {
            PetShopDBContext context = new PetShopDBContext();
            try
            {
                Cage cage = new Cage
                {
                    IsEmpty = false,
                    Name = "Pesho"
                };

                context.Cages.Add(cage);
                context.SaveChanges();
            }
            //In this case the exception happend on the DB and we have to cultivate this exceprion to find its massage
            catch (DbEntityValidationException ex)
            {

                foreach (DbEntityValidationResult dbEntityValidatonResult in ex.EntityValidationErrors)
                {
                    foreach (DbValidationError dbValidationError in dbEntityValidatonResult.ValidationErrors)
                    {
                        Console.WriteLine(dbValidationError.ErrorMessage);
                    }
                }
            }
           
        }
    }
}
