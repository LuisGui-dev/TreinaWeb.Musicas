using System.ComponentModel.DataAnnotations;

namespace TreinaWeb.Musicas.Web.ViewModels.Album
{
    public class AlbumExibicaoViewModel
    {

        public int Id { get; set; }

        [Display(Name = "Nome do álbum")]
        public string Nome { get; set; }

        [Display(Name = "Ano do álbum")]
        public int Ano { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [Display(Name = "Email de contato")]
        [DataType(dataType:DataType.EmailAddress)]
        public string Email { get; set; }
    }
}