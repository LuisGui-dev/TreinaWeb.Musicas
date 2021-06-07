using AutoMapper;
using TreinaWeb.Musicas.Web.AutoMapper;

namespace TreinaWeb.Musicas.Web
{
    public static class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.AddProfile<DominioParaViewMoldelProfile>();
            Mapper.AddProfile<ViewModelParaDominioProfile>();
        }
    }
}