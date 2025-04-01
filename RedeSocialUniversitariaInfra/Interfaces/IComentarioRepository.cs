using RedeSocialUniversitariaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialUniversitariaInfra.Interfaces
{
    public interface IComentarioRepository
    {
        public void comentarPostagem(int PostagemId, int usuarioId, string conteudo);
        public void deleteComentario(int comentarioId);
        public void editarComentario(string conteudo);
    }
}
