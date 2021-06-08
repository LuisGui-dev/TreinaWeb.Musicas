using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TreinaWeb.Musicas.AcessoDados.Entity.Context;
using TreinaWeb.Musicas.Dominio;
using TreinaWeb.Repositorios.Comum.Entity;

namespace TreinaWeb.Musicas.Repositorios.Entity
{
    public class MusicasRepositorio : RepositorioGenericoEntity<Musica, long>

    {
        public MusicasRepositorio(MusicasDbContext contexto) : base(contexto)
        {

        }

        public override List<Musica> Selecionar()
        {
            return _contexto.Set<Musica>().Include(p => p.Album).ToList();
        }

        public override Musica SelecionarPorId(long id)
        {
            return _contexto.Set<Musica>().Include(p => p.Album).SingleOrDefault(m => m.Id == id);
        }
    }
}