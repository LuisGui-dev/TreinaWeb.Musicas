using System.Collections.Generic;

namespace TreinaWeb.Repositorios.Comum
{
    public interface IRepositorioGenerico<TEntidade, TChave>
        where TEntidade : class
    {
        List<TEntidade> Selecionar();
        TEntidade SelecionarPorId(TChave id);
        void Inserir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void ExcluirPorId(TChave id);
    }
}