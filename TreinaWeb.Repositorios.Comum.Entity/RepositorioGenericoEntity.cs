using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace TreinaWeb.Repositorios.Comum.Entity
{
    public class RepositorioGenericoEntity<TEntidade, Tchave> : IRepositorioGenerico<TEntidade, Tchave>
    where TEntidade : class
    {
        private DbContext _contexto;

        public RepositorioGenericoEntity(DbContext contexto)
        {
            _contexto = contexto;
        }
        public List<TEntidade> Selecionar()
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public TEntidade SelecionarPorId(Tchave id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }

        public void Inserir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Add(entidade);
            _contexto.SaveChanges();
        }

        public void Alterar(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(TEntidade entidade)
        {
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public void ExcluirPorId(Tchave id)
        {
            TEntidade entidade = SelecionarPorId(id);
            Excluir(entidade);
        }
    }
}