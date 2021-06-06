using AutoMapper;
using TreinaWeb.Musicas.Dominio;
using TreinaWeb.Musicas.Web.ViewModels.Album;

namespace TreinaWeb.Musicas.Web.AutoMapper
{
    public class DominioParaViewMoldelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Album, AlbumIndexViewModel>();
        }
    }
}