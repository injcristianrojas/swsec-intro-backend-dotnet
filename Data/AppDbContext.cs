using Microsoft.EntityFrameworkCore;
using swsec_intro_backend_dotnet.Models;

namespace swsec_intro_backend_dotnet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User{Id = 1, Username = "zorzal", Password = "fio", Type = 2});
            modelBuilder.Entity<User>().HasData(new User{Id = 2, Username = "admin", Password = "2mns8uu5w3vnut", Type = 1});
            modelBuilder.Entity<User>().HasData(new User{Id = 3, Username = "chincol", Password = "fiofio", Type = 2});
            modelBuilder.Entity<User>().HasData(new User{Id = 4, Username = "tiuque", Password = "pah", Type = 2});
            modelBuilder.Entity<User>().HasData(new User{Id = 5, Username = "loica", Password = "roji", Type = 2});

            modelBuilder.Entity<Post>().HasData(new Post{Id = 1, Message = "Bienvenidos al foro de Fans de las Aves Chilenas. Soy el Administrador."});
            modelBuilder.Entity<Post>().HasData(new Post{Id = 2, Message = "Se informa que la API se encuentra deshabilitada hasta nuevo aviso."});
        }
    }
}