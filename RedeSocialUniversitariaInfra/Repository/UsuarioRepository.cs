using RedeSocialUniversitariaDomain;
using RedeSocialUniversitariaInfra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialUniversitariaInfra.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private AppDBContext _dbContext;
        public UsuarioRepository(AppDBContext dbcontext) { 
            _dbContext = dbcontext;
        }

        public Usuario findUsuario(int id)
        {
            var usuario = _dbContext.Usuarios.Find(id);
            
            return usuario;
        }
        public List<Usuario> getUsuarios()
        {
            var usuarios = _dbContext.Usuarios.ToList();

            return usuarios;
        }
        public void saveUsuario(Usuario usuario)
        {
            _dbContext.Usuarios.Add(usuario);
            _dbContext.SaveChanges();
        }
        public void deleteUsuario(int id)
        {
            var usuario = findUsuario(id);

            if(usuario != null)
            {
                _dbContext.Usuarios.Remove(usuario);
                _dbContext.SaveChanges();
            }            
        }
        public void updateUsuario(int id, Usuario usuario)
        {
            if (id == usuario.IdUsuario)
            {
                _dbContext.Usuarios.Update(usuario);
                _dbContext.SaveChanges();
            }
        }

        public void seguirUsuario(int id, Usuario usuarioSeguidor)
        {
            var usuario = findUsuario(id);

            usuario.Seguidores.Add(usuarioSeguidor);

            _dbContext.Usuarios.Update(usuario);
            _dbContext.SaveChanges();
        }
    }
}
