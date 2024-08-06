using ScreenSound.ScreenSoundPOO;

class Program
{

    private static void Main(string[] args)
    {

        Banda banda1 = new Banda("Queen");

        Album album1 = new Album("A night of the opera");

        Musica musica1 = new Musica("Love of my life", banda1, 60, true);




        album1.AdicionarMusica(musica1);
        banda1.ExibirDiscografia();

        banda1.AdicionarAlbum(album1);
        System.Console.WriteLine(musica1.DescricaoResumida);
        album1.ExibirMusicasAlbum();


    }



}