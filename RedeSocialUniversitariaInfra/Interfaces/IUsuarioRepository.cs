using RedeSocialUniversitariaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialUniversitariaInfra.Interfaces
{
    public interface IUsuarioRepository
    {
        public Usuario findUsuario(int id);
        public List<Usuario> getUsuarios();
        public void saveUsuario(Usuario usuario);
        public void deleteUsuario(int id);
        public void updateUsuario(int id, Usuario usuario);
        public void seguirUsuario(int id, Usuario usuarioSeguidor);
    }
}
