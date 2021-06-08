using System.ComponentModel.DataAnnotations;

namespace TreinaWeb.Musicas.Web.ViewModels.Musica
{
    public class MusicaViewModel
    {
        [Required(ErrorMessage = "O ID é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da musica é obrigatório")]
        [MaxLength(50, ErrorMessage = "O nome da musica pode ter no máximo 50 caracteres")]
        [Display(Name = "Nome da música")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Selecione um albuum válido")]
        [Display(Name = "Álbum")]
        public int IdAlbum { get; set; }
    }
}