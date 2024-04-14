using AppsApi.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Text.Json;

namespace AppsApi.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
               
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<App>().HasMany(a => a.Genres).WithMany(g => g.Apps).UsingEntity(j => j.ToTable("AppGenre"));

            modelBuilder.Entity<App>().HasMany(a => a.Images).WithOne(i => i.App).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<App>().HasOne(a => a.Developer).WithMany(a => a.Apps).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<App>().HasMany(a => a.Reviews).WithOne(a => a.App).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>().HasMany(u => u.AppsLibrary).WithMany(a => a.UsersLibrary).UsingEntity(j => j.ToTable("UserLibrary"));
            modelBuilder.Entity<User>().HasMany(u => u.AppsWishlist).WithMany(a => a.UsersWishlist).UsingEntity(j => j.ToTable("UserWishlist"));
            modelBuilder.Entity<User>().HasMany(a => a.Reviews).WithOne(u => u.User).OnDelete(DeleteBehavior.Cascade);

            
            modelBuilder.Entity<User>().Navigation(l => l.AppsLibrary).AutoInclude();
            modelBuilder.Entity<User>().Navigation(l => l.AppsWishlist).AutoInclude();
            modelBuilder.Entity<User>().Navigation(l => l.Reviews).AutoInclude();

            modelBuilder.Seed();
            
           

        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<App> Apps { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }


    }
}
