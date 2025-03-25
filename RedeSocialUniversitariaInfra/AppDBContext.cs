using Microsoft.EntityFrameworkCore;
using RedeSocialUniversitariaDomain;

namespace RedeSocialUniversitariaInfra
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagem { get; set; }
        public DbSet<Evento> Evento { get; set; }
    }
}
