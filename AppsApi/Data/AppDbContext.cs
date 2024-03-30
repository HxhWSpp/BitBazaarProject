using AppsApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Text.Json;

namespace AppsApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
               
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<App>().HasMany(a => a.Genres).WithMany(g => g.Apps).UsingEntity(j => j.ToTable("AppGenre"));

            modelBuilder.Entity<App>().HasMany(a => a.Images).WithOne(i => i.App).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<App>().HasOne(a => a.Developer).WithMany(a => a.Apps).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<App>().HasMany(a => a.Reviews).WithOne(a => a.App).OnDelete(DeleteBehavior.Cascade);

            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<App> Apps { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<AppsApi.Data.Entities.Review>? Review { get; set; }


    }
}
