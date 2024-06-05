using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KargoTakipUygulaması.Models;

namespace KargoTakipUygulaması.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<CargoStatus> CargoStatuses { get; set; }
        public DbSet<CargoLocation> CargoLocations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(u => u.SentCargos)
                .WithOne(c => c.Sender)
                .HasForeignKey(c => c.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Cargo>()
                .HasMany(c => c.CargoStatuses)
                .WithOne(cs => cs.Cargo)
                .HasForeignKey(cs => cs.CargoId);

            modelBuilder.Entity<Cargo>()
                .HasMany(c => c.CargoLocations) 
                .WithOne(cl => cl.Cargo)
                .HasForeignKey(cl => cl.CargoId);

            modelBuilder.Entity<Cargo>()
                .Property(c => c.Latitude)
                .HasDefaultValue(37.0);

            modelBuilder.Entity<Cargo>()
                .Property(c => c.Longitude)
                .HasDefaultValue(35.3213);
        }
    }
}