using System.ComponentModel.DataAnnotations;
using TreinaWeb.Musicas.Web.Annotations;

namespace TreinaWeb.Musicas.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do álbum")]
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(100, ErrorMessage = "O nome do álbum podera ter no maximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Ano do álbum")]
        [Required(ErrorMessage = "O ano do álbum é obrigatório")]
        public int Ano { get; set; }

        [Display(Name = "Observações")]
        [MaxLength(1000, ErrorMessage = "Você exedeu a quantidade de caracteres para observação que é no máximo 1000 caracteres")]
        public string Observacoes { get; set; }

        [Display(Name = "Email de contato")]
        [DataType(dataType: DataType.EmailAddress)]
        [Required(ErrorMessage = "O email de contato é obrigatório")]
        [MaxLength(50, ErrorMessage = "O email não pode ter mais que 50 caracteres")]
        [EmailTreinaWeb(ErrorMessage = "O email tem que ser da TreinaWeb")]
        public string Email { get; set; }
    }
}