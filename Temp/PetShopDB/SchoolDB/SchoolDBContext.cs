namespace SchoolDB
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext()
            : base("name=SchoolDBContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<SchoolDBContext>());
        }      

        public DbSet<Student> Students { get; set; } 

        public DbSet<Teacher> Techers { get; set; }
    }  
}