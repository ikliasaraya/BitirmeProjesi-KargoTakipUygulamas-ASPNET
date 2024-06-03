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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define relationships and keys
            modelBuilder.Entity<User>()
                .HasMany(u => u.SentCargos)
                .WithOne(c => c.Sender)
                .HasForeignKey(c => c.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Cargo>()
                .HasMany(c => c.CargoStatuses)
                .WithOne(cs => cs.Cargo)
                .HasForeignKey(cs => cs.CargoId);
        }
    }
}
