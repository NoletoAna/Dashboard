using Dashboard.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chamado>()
                .HasOne(c => c.Criador)
                .WithMany(u => u.ChamadosCriados)
                .HasForeignKey(c => c.CriadorId);

            modelBuilder.Entity<Chamado>()
                .HasOne(c => c.Responsavel)
                .WithMany(u => u.ChamadosResponsavel)
                .HasForeignKey(c => c.ResponsavelId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Chamado>()
                .HasOne(c => c.Categoria)
                .WithMany(c => c.Chamados)
                .HasForeignKey(c => c.CategoriaId);
        }
    }
}
