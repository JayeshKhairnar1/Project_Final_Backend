using DotNetProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetProject.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Segment> Segments { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }   
        public DbSet<Model> Models { get; set; }
      
    }
}
