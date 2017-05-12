namespace TestRelation
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

        public IDbSet<Student> Students { get; set; }

        public IDbSet<StudentAddress> StudentAddresses { get; set; }

        public IDbSet<School> School { get; set; }

        public IDbSet<Subject> Subjects { get; set; }

        public IDbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasRequired(st => st.StudentAddress)
                .WithRequiredPrincipal(address => address.Student);

            modelBuilder.Entity<School>()
                .HasMany(sch => sch.Students)
                .WithOptional(student => student.School);

            modelBuilder.Entity<Student>() //Create Many To Many In Table Student as one student have a lot of frends 
                .HasMany(st => st.Friends)
                .WithMany();

            base.OnModelCreating(modelBuilder);
        }
    }
   
}