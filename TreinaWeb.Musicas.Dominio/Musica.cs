namespace TreinaWeb.Musicas.Dominio
{
    public class Musica
    {
        public long Id { get; set; }
        public string Nome { get; set; }

        public virtual Album Album { get; set; }
        public int IdAlbum { get; set; }
    }
}