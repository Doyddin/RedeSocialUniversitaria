using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialUniversitariaDomain
{
    public class Comentario
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Conteudo { get; set; }
        public Guid PostagemId { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Postagem Postagem { get; set; }
    }
}
