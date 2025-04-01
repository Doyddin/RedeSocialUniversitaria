using System.ComponentModel.DataAnnotations;

namespace RedeSocialUniversitariaDomain
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<Usuario> Seguidores { get; set; } = new();
        public List<Comentario> Comentarios { get; set; } = new();
        public List<Postagem> Curtidas { get; set; } = new();
    }
}
