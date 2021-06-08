using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TreinaWeb.Musicas.AcessoDados.Entity.Context;
using TreinaWeb.Musicas.Dominio;
using TreinaWeb.Repositorios.Comum;
using TreinaWeb.Repositorios.Comum.Entity;

namespace TreinaWeb.Musicas.Repositorios.Entity
{
    public class AlbunsRepositorio : RepositorioGenericoEntity<Album, int>
    {
        public AlbunsRepositorio(MusicasDbContext contexto)
        : base(contexto)
        {

        }

        public override List<Album> Selecionar()
        {
            return _contexto.Set<Album>().Include(p => p.Musicas).ToList();
        }

        public override Album SelecionarPorId(int id)
        {
            return _contexto.Set<Album>().Include(p => p.Musicas).SingleOrDefault(a => a.Id == id);
        }
    }
}