namespace Ads.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Data;
    using Models;

    public partial class AdsDBContext : DbContext
    {
        public AdsDBContext()
            : base("name=AdsDBContext")
        {
        }

        public virtual DbSet<Ad> Ads { get; set; }
        public virtual DbSet<AdStatus> AdStatuses { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Town> Towns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdStatus>()
                .HasMany(e => e.Ads)
                .WithRequired(e => e.AdStatus)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.Ads)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.OwnerId);
        }
    }
}
