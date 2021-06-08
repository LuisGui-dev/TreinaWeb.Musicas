using System.Web.UI;
using AutoMapper;
using TreinaWeb.Musicas.Dominio;
using TreinaWeb.Musicas.Web.ViewModels.Album;
using TreinaWeb.Musicas.Web.ViewModels.Musica;

namespace TreinaWeb.Musicas.Web.AutoMapper
{
    public class DominioParaViewMoldelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Album, AlbumExibicaoViewModel>()
                .ForMember(p => p.Nome, opt =>
                {
                    opt.MapFrom(src =>
                        $"{src.Nome} ({src.Ano})"
                    );
                });
            Mapper.CreateMap<Album, AlbumViewModel>();
            Mapper.CreateMap<Musica, MusicaExibicaoViewModel>()
                .ForMember(p => p.NomeAlbum, opt =>
                {
                    opt.MapFrom(src =>
                        src.Album.Nome
                    );
                });
            Mapper.CreateMap<Musica, MusicaViewModel>();
        }
    }
}