﻿using System;
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
        public Guid Id { get; set; }
        public Guid AutorId { get; set; }
        public Usuario Autor { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataHora { get; set; }
        public List<Comentario> Comentarios { get; set; } = new();
        public List<Usuario>? Curtidas { get; set; } = new();
    }
}
