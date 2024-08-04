using ScreenSound.ScreenSoundPOO;

class Program
{

    private static void Main(string[] args)
    {

        Album album1 = new Album();
        album1.Nome = "A night of the opera";


        Musica musica1 = new Musica();
        musica1.Nome = "Love of my life";
        musica1.Artista = "Queen";
        musica1.Duracao = 2;
        musica1.Disponivel = true;

        album1.AdicionarMusica(musica1);
        System.Console.WriteLine(musica1.DescricaoResumida);
        album1.ExibirMusicasAlbum();

    }



}