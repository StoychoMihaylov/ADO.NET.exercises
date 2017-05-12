namespace StudentSystemDB
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentSystemDBContext : DbContext
    {
        
        public StudentSystemDBContext()
            : base("name=StudentSystemDBContext")
        {
        }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Cours> Courses { get; set; }

        public IDbSet<Resource> Resources { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }

        public IDbSet<Licens> Licenses { get; set; }
    }

    
}