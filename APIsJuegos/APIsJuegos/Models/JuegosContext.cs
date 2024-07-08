using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace APIsJuegos.Models
{
    public partial class JuegosContext : DbContext
    {
        public JuegosContext() { }
        public JuegosContext(DbContextOptions<JuegosContext> options) : base (options){ }

        public virtual DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Producto__756A5402081044CF");

                entity.ToTable("Producto");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
