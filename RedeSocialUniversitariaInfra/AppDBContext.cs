using Microsoft.EntityFrameworkCore;
using RedeSocialUniversitariaDomain;

namespace RedeSocialUniversitariaInfra
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RedeSocialDb;Trusted_Connection=True;");
        }
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagem { get; set; }
        public DbSet<Evento> Evento { get; set; }
        public DbSet<Comentario> Comentario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Seguidores)
                .WithMany();

            modelBuilder.Entity<Postagem>()
                .HasOne(p => p.Autor)
                .WithMany()
                .HasForeignKey(p => p.AutorId);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Usuario)
                .WithMany(u => u.Comentarios)
                .HasForeignKey(c =>  c.UsuarioId);

            modelBuilder.Entity<Comentario>()
                .HasOne(c => c.Postagem)
                .WithMany(p => p.Comentarios)
                .HasForeignKey(c => c.PostagemId);

            modelBuilder.Entity<Postagem>()
                .HasMany(p => p.Curtidas)
                .WithMany(u => u.Curtidas)
                .UsingEntity<Dictionary<string, object>>(
                "PostagemCurtidas",
                j => j
                    .HasOne<Usuario>()
                    .WithMany()
                    .HasForeignKey("UsuarioId")
                    .OnDelete(DeleteBehavior.Restrict),
                j => j
                    .HasOne<Postagem>()
                    .WithMany()
                    .HasForeignKey("PostagemId")
                    .OnDelete(DeleteBehavior.Cascade)
                );

            modelBuilder.Entity<Evento>()
                .HasMany(e => e.Participantes)
                .WithMany();
        }
    }
}
