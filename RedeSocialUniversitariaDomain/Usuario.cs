using System.ComponentModel.DataAnnotations;

namespace RedeSocialUniversitariaDomain
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        
        public string Nome { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public List<Usuario> Seguidores { get; set; }
        public Usuario()
        {
            Seguidores = new List<Usuario>();
        }
    }
}
