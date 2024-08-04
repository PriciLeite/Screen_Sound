using ScreenSound.ScreenSoundPOO;

class Program
{

    private static void Main(string[] args)
    {
        Musica musica1 = new Musica();
        musica1.Nome = "Love of my life";
        musica1.Artista = "Queen";
        musica1.Duracao = 2;

        musica1.ExibirFichaTecnica();
        System.Console.WriteLine(musica1.DescricaoResumida);
    }



}