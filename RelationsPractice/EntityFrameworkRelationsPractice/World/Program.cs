using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World.Models;

namespace World
{
    class Program
    {
        static void Main()
        {
            WorldDBContext context = new WorldDBContext();
            context.Towns.Add(new Town()
            {
                Name = "Plovdiv",
                People = new List<Person>()
                {
                    new Person() { Name = "Nasko"},
                    new Person() { Name = "Gosho"},
                    new Person() { Name = "Mincho"},
                    new Person() { Name = "Psiho"},
                    new Person() { Name = "Vasko"},
                    new Person() { Name = "Niki"},
                    new Person() { Name = "Enzimo"},
                    new Person() { Name = "Gungin"},
                    new Person() { Name = "Eva"},
                    new Person() { Name = "Strahil"},
                    new Person() { Name = "Ema"},
                    new Person() { Name = "Borqna"},
                    new Person() { Name = "Lin"},
                    new Person() { Name = "Alex"},
                    new Person() { Name = "Marin"},
                    new Person() { Name = "Kolio"},
                    new Person() { Name = "Erkan"},
                    new Person() { Name = "Galin"},
                    new Person() { Name = "Evanin"},
                    new Person() { Name = "Stanislav"}
                }
            });
            context.SaveChanges();

            //SqlParameter nameParameter = new SqlParameter("@param", SqlDbType.NVarChar);
            //nameParameter.Value = "Kolio";
            //var people = context.Database.SqlQuery<Person>("SELECT * FROM People WHETE Name = @param", nameParameter);
            //foreach (Person man in people)
            //{
            //    Console.WriteLine(man.Name);
            //}

            var persons = context.Persons.Select(per => new //Anonimen obekt , sluji ni kogato iskame da napravim 
            {                                               //malka SQL zaqkva kato posochim tochno kakvo iskame da vzemem
                PersonName = per.Name,                      //Obekta e samo rad only i mojem samo da gi vzemem, no ne mojem da gi promenqme
                Age = per.Age
            });

            foreach (var per in persons)
            {
                Console.WriteLine($"{per.PersonName}, {per.Age}");
            }
        }
    }
}
