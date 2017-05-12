namespace World
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class WorldDBContext : DbContext
    {
        
        public WorldDBContext()
            : base("name=WorldDBContext")
        {
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Town> Towns { get; set; }
        
    }

  
}