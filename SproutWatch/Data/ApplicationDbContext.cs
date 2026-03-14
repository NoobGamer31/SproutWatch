using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SproutWatch.Models;

namespace SproutWatch.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Tables
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<GardenZone> GardenZones { get; set; }
        public DbSet<SensorDataLog> SensorDataLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
