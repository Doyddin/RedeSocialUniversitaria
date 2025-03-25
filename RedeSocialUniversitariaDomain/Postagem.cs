using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialUniversitariaDomain
{
    public class Postagem
    {
        [Key]
        public int IdPostagem { get; set; }
        public Usuario Autor { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataHora { get; set; }
    }
}
