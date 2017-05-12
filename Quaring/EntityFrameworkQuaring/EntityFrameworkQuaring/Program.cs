using EntityFramework.Extensions;
using EntityFrameworkQuaring.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkQuaring
{
    class Program
    {
        static void Main(string[] args)
        {
            WorldDBContext context = new WorldDBContext();
            //context.Towns.Add(new Models.Town()
            //{
            //    Name = "Plovdiv",
            //    People = new List<Person>()
            //    {
            //        new Person() { Name = "Gosho"},
            //        new Person() { Name = "Nasko"},
            //        new Person() { Name = "Pesho"},
            //        new Person() { Name = "Vasko"},
            //        new Person() { Name = "Kiros"},
            //        new Person() { Name = "Misho"},
            //        new Person() { Name = "Ivan"},
            //    }                
            //});
            //context.Towns.Add(new Town()
            //{
            //    Name = "Stara Zagora",
            //    People = new List<Person>()
            //    {
            //        new Person() { Name = "Dragan"},
            //        new Person() { Name = "Petkan"},
            //        new Person() { Name = "Monchil"},
            //        new Person() { Name = "Alex"},
            //        new Person() { Name = "Sasho"},
            //        new Person() { Name = "Dana"},
            //        new Person() { Name = "Ivana"},

            //    }
            //});
            //context.SaveChanges();

            //var people = context.Database.SqlQuery<Person>("SELECT * FROM People");
            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person.Name);
            //}

            //var people = context.Persons.SqlQuery("SELECT * FROM People");
            //foreach (var person  in people)
            //{
            //    Console.WriteLine(person.Name);
            //}

            //SqlParameter nameParameter = new SqlParameter("@param", SqlDbType.NVarChar);
            //nameParameter.Value = "Ivan";
            //var people = context.Database.SqlQuery<Person>("SELECT * FROM People WHERE Name = @param", nameParameter);
            //foreach (Person person in people)
            //{
            //    Console.WriteLine($"{person.Name}, {person.Age}");
            //}

            //It's anonimous quary we can give only that what we want!!!
            //It's when we want to desplay exact something but this is read only and we can't change it
            //var persons = context.Persons.Select(person => new
            //{
            //    PersonName = person.Name,
            //    TownName = person.Town.Name,
            //});
            //var persons = context.Persons.Select(person => new
            //{
            //    TownName = person.Town.Name,
            //    Age = person.Age
            //}).ToArray();

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"{persons[i].TownName}, {persons[i].Age}");
            //}

            //var people = context.Persons.GroupBy(persons => new
            //{
            //    persons.Name,
            //    persons.TownId
            //});
            //foreach (var pers in people)
            //{
            //    Console.WriteLine(pers.Key.Name + " " + pers.Key.TownId);
            //}

            //Town town = new Town()
            //{
            //    Name = "Sofia"
            //};
            //Console.WriteLine(context.Entry(town).State);
            //var person = context.Persons.First();
            //person.Name = "Slavcho";
            //context.Entry(person).State = EntityState.Deleted; // or updated,changes,
            //Console.WriteLine(context.Entry(person).State);

            //This will make 5 other select in database
            //var person = context.Persons.Take(5);
            //context.Persons.RemoveRange(person);
            //context.SaveChanges();
            //or
            //var persons = context.Persons.Take(5);
            //Random rnd = new Random();
            //foreach (Person person in persons)
            //{
            //    person.Age = rnd.Next(1, 100);
            //}
            //context.SaveChanges();

            //If we want to do this with only one select we have to use external method in EntityFRExternal in NuGEt package
            //context.Persons.Delete(pers => pers.Name == "Ivan");
            //context.SaveChanges(); // And it's happend with only one select ;)
            //var naskos = context.Persons.Where(pers => pers.Name == "Nasko");
            //context.Persons.Update(naskos, per => new Person()
            //{
            //    Age = 50
            //});
            //context.SaveChanges();
            //it's seccond way to do update 
            //context.Persons.Update(per => per.Name == "Nasko", per => new Person() { Age = per.Age + 5, Name = "Kaloqn"});
            //context.SaveChanges();

            //var towns = context.Towns.Where(town => town.People.Count != 0).Include(town => town.People);
            //foreach (var town in towns)
            //{
            //    Console.WriteLine(town.Name + " " + town.People.First().Name);
            //}
        }
    }
}
