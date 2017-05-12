namespace GringottsDB
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class GringottsDBContext : DbContext
    {
        public GringottsDBContext()
            : base("name=GringottsDBContext")
        {
        }     
        
        public IDbSet<WizardDeposit> WizardDeposits { get; set; }

        public IDbSet<User> Users { get; set; }
    } 
}