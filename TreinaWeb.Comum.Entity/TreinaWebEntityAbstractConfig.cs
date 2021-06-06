using System.Data.Entity.ModelConfiguration;

namespace TreinaWeb.Comum.Entity
{
    public abstract class TreinaWebEntityAbstractConfig<T> : EntityTypeConfiguration<T> where T : class
    {
        public TreinaWebEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChaveEstrangeiras();
        }

        protected abstract void ConfigurarChaveEstrangeiras();
        protected abstract void ConfigurarChavePrimaria();
        protected abstract void ConfigurarCamposTabela();
        protected abstract void ConfigurarNomeTabela();
    }
}