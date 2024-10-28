using Microsoft.EntityFrameworkCore;
using swsec_intro_backend_dotnet.Models;

namespace swsec_intro_backend_dotnet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User{Id = 1, Username = "admin", Password = "default", Type = 1});
            modelBuilder.Entity<User>().HasData(new User{Id = 2, Username = "jperez", Password = "123", Type = 2});
        }
    }
}