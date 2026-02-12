using Microsoft.EntityFrameworkCore;
using Biblioteca.Core.Entidades;

namespace Biblioteca.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ConfigurarAutor(modelBuilder);
            ConfigurarLibro(modelBuilder);
        }

        private static void ConfigurarAutor(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.ToTable("Autor");
                entity.HasKey(a => a.Id);

                entity.Property(a => a.NombreCompleto)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(a => a.FechaNacimiento)
                      .IsRequired();

                entity.Property(a => a.CorreoElectronico)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.HasIndex(a => a.CorreoElectronico)
                      .IsUnique();
            });
        }

        private static void ConfigurarLibro(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.ToTable("Libro");
                entity.HasKey(l => l.Id);

                entity.Property(l => l.Titulo)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(l => l.Año)
                      .IsRequired();

                entity.Property(l => l.AutorId)
                      .IsRequired();
            });
        }
    }
}
