using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using TestTask.Models;

namespace TestTask.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Car>().HasKey(b => b.Id);
            builder.Entity<Owner>().HasKey(b => b.Id);

            builder.Entity<CarOwner>().HasKey(b => b.Id);
            builder.Entity<CarOwner>()
                .HasOne(b => b.Car)
                .WithMany(b => b.CarOwners)
                .HasForeignKey(b => b.CarId);
            builder.Entity<CarOwner>()
                .HasOne(b => b.Owner)
                .WithMany(b => b.Owners)
                .HasForeignKey(b => b.OwnerId);
        }
    }
}
