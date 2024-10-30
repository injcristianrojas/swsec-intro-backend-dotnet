using Microsoft.EntityFrameworkCore;
using swsec_intro_backend_dotnet.Models;

namespace swsec_intro_backend_dotnet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new User{Id = 1, Username = "zorzal", Password = "fio", Type = 2});
            modelBuilder.Entity<User>().HasData(new User{Id = 2, Username = "admin", Password = "123", Type = 1});
            modelBuilder.Entity<User>().HasData(new User{Id = 3, Username = "chincol", Password = "fiofio", Type = 2});
            modelBuilder.Entity<User>().HasData(new User{Id = 4, Username = "tiuque", Password = "pah", Type = 2});
            modelBuilder.Entity<User>().HasData(new User{Id = 5, Username = "loica", Password = "roji", Type = 2});

            modelBuilder.Entity<Message>().HasData(new Message{Id = 1, Text = "Bienvenidos al foro de Fans de las Aves Chilenas. Soy el Administrador."});
            modelBuilder.Entity<Message>().HasData(new Message{Id = 2, Text = "Se informa que la API se encuentra deshabilitada hasta nuevo aviso."});
        }
    }
}