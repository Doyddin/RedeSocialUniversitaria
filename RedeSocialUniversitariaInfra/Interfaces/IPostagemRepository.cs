using RedeSocialUniversitariaDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialUniversitariaInfra.Interfaces
{
    public interface IPostagemRepository
    {
        public Postagem findPostagem(int id);
        public List<Postagem> getPostagens();
        public void savePostagem(Postagem postagem);
        public void deletePostagem(int id);
        public void updatePostagem(int id, Usuario usuario);
    }
}
