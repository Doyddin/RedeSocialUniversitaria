using RedeSocialUniversitariaDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialUniversitariaInfra.Interfaces
{
    public interface ICurtidaRepository
    {
        public void curtirPostagem(int postagemId, int usuarioId);
        public void deleteCurtida(int curtidaId);
    }
}
