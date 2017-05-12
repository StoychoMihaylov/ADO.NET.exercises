namespace PetShopDB
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PetShopDBContext : DbContext
    {
        public PetShopDBContext()
            : base("name=PetShopDBContext")
        {
        }     
        
        public IDbSet<Cat> Cats { get; set; } 

        public IDbSet<Dog> Dogs { get; set; }

        public IDbSet<Cage> Cages { get; set; }

        public IDbSet<Person> People { get; set; }

    }
}