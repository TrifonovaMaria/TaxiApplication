namespace DataModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelsTaxi : DbContext
    {
        public ModelsTaxi()
            : base("name=ModelsTaxi")
        {
        }

        public virtual DbSet<Authorization> Authorization { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Driver> Driver { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authorization>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Authorization>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Authorization>()
                .HasMany(e => e.Customer)
                .WithRequired(e => e.Authorization)
                .HasForeignKey(e => e.ID_Auth)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Authorization>()
                .HasMany(e => e.Driver)
                .WithRequired(e => e.Authorization)
                .HasForeignKey(e => e.ID_Auth)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Order)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.ID_Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .Property(e => e.Phone)
                .IsFixedLength();

            modelBuilder.Entity<Driver>()
                .Property(e => e.License)
                .IsFixedLength();

            modelBuilder.Entity<Driver>()
                .Property(e => e.CarNumber)
                .IsFixedLength();

            modelBuilder.Entity<Driver>()
                .Property(e => e.CarClass)
                .IsUnicode(false);

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Order)
                .WithOptional(e => e.Driver)
                .HasForeignKey(e => e.ID_Driver);

            modelBuilder.Entity<Order>()
                .Property(e => e.DepartureAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.DestinationAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CarClass)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.PaymentMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Status)
                .IsUnicode(false);
        }
    }
}
