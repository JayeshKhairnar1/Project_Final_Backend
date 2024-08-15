using Grp4.models;
using Microsoft.EntityFrameworkCore;

namespace Grp4.repositories
{
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties for each entity
        public DbSet<AlternateComponent> AlternateComponents { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<Component> Components { get; set; }
     
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // AlternateComponent relationships
            modelBuilder.Entity<AlternateComponent>()
                .HasOne(ac => ac.Component)
                .WithMany(c => c.AlternateComponents)
                .HasForeignKey(ac => ac.CompId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AlternateComponent>()
                .HasOne(ac => ac.Model)
                .WithMany(m => m.AlternateComponents)
                .HasForeignKey(ac => ac.ModId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<AlternateComponent>()
                .HasOne(ac => ac.AltComponent)
                .WithMany()
                .HasForeignKey(ac => ac.AltCompId)
                .OnDelete(DeleteBehavior.Restrict);

            // CarDescription relationship
            modelBuilder.Entity<CarDescription>()
                .HasMany(cd => cd.Models)
                .WithOne()
                .HasForeignKey(m => m.Id)
                .OnDelete(DeleteBehavior.Restrict);

            // Component relationships
            modelBuilder.Entity<Component>()
                .HasMany(c => c.Vehicles)
                .WithOne(v => v.Component)
                .HasForeignKey(v => v.CompId)
                .OnDelete(DeleteBehavior.Restrict);

           

            // Manufacturer relationships
            modelBuilder.Entity<Manufacturer>()
                .HasOne(m => m.Segment)
                .WithMany(s => s.Manufacturers)
                .HasForeignKey(m => m.SegId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Manufacturer>()
                .HasMany(m => m.Models)
                .WithOne(mod => mod.Manufacturer)
                .HasForeignKey(mod => mod.ManuId)
                .OnDelete(DeleteBehavior.Restrict);

            // Model relationships
            modelBuilder.Entity<Model>()
                .HasOne(mod => mod.Segment)
                .WithMany(s => s.Models)
                .HasForeignKey(mod => mod.SegId);
                

            // Vehicle relationships
            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Component)
                .WithMany(c => c.Vehicles)
                .HasForeignKey(v => v.CompId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Model)
                .WithMany()
                .HasForeignKey(v => v.ModId);
                

            // Additional configurations if needed (e.g., indexes, default values)
        }

    }

}
