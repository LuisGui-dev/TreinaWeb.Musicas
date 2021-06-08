using System.ComponentModel.DataAnnotations;

namespace TreinaWeb.Musicas.Web.ViewModels.Musica
{
    public class MusicaExibicaoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome da musica")]
        public string Nome { get; set; }

        [Display(Name = "Nome do album")]
        public string NomeAlbum { get; set; }
    }
}