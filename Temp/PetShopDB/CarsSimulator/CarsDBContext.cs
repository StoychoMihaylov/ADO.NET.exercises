namespace CarsSimulator
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarsDBContext : DbContext
    {
        
        public CarsDBContext()
            : base("name=CarsDBContext")
        {
        }

        public IDbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>()                       //Nai-burzata strategiq
            //    .Map<LuxuriosCar>(m => m.Requires("Type")
            //    .HasValue("Lux"))
            //    .Map<Batmobile>(m => m.Requires("Type")
            //    .HasValue("Batty"));

            modelBuilder.Entity<LuxuriosCar>().ToTable("LuxuriosCars"); //Pravi otdelni tablici
            modelBuilder.Entity<Batmobile>().ToTable("Batmobiles");
            base.OnModelCreating(modelBuilder);
        }

    }

   
}