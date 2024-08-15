
using Grp4.models;
using Microsoft.EntityFrameworkCore;


namespace Grp4.repositories
{
    public class VconfRepository : DbContext
    {
        public VconfRepository(DbContextOptions options) : base(options)
        {
        }


        // DbSets for each table
        public DbSet<User> Users { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Segment> Segments { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        public DbSet<AlternateComponent> AlternateComponents { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }  

    }
}
