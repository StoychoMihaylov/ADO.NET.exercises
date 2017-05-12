namespace EntityFrameworkQuaring
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
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Person> Persons { get; set; }
        
        public DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Town>()
                .HasMany(tw => tw.People)
                .WithRequired(peson => peson.Town)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }  
}