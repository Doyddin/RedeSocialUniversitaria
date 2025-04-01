using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialUniversitariaDomain
{
    public class Evento
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Local { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHora { get; set; }
        public List<Usuario> Participantes { get; set; } = new();
    }
}
