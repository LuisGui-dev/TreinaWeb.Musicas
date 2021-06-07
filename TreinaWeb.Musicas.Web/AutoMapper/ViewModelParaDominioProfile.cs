using AutoMapper;
using TreinaWeb.Musicas.Dominio;
using TreinaWeb.Musicas.Web.ViewModels.Album;

namespace TreinaWeb.Musicas.Web.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AlbumViewModel, Album>();
        }
    }
}