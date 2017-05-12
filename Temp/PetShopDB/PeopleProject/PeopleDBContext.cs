namespace PeopleProject
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PeopleDBContext : DbContext
    {
        public PeopleDBContext()
            : base("name=PeopleDBContext")
        {
        }       
        public IDbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().Property(person => person.FirstName).HasMaxLength(40);
            base.OnModelCreating(modelBuilder);
        }
    }    
}