namespace ConsoleShoesServer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ShoesDB : DbContext
    {
        public ShoesDB()
             : base("name=ShoesDB")
             //: base("name=ShopDBHome")
        {
        }

        public virtual DbSet<AgeStatu> AgeStatus { get; set; }
        public virtual DbSet<Factory> Factories { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Sho> Shoes { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AgeStatu>()
                .HasMany(e => e.Shoes)
                .WithRequired(e => e.AgeStatu)
                .HasForeignKey(e => e.AgeState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Factory>()
                .HasMany(e => e.Shoes)
                .WithRequired(e => e.Factory)
                .HasForeignKey(e => e.Manufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Shoes)
                .WithRequired(e => e.Gender)
                .HasForeignKey(e => e.GenderState)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sho>()
                .Property(e => e.IncomePrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.Shoes)
                .WithRequired(e => e.Size)
                .HasForeignKey(e => e.ModelSize)
                .WillCascadeOnDelete(false);
        }
    }
}
