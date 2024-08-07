using ScreenSound.ScreenSoundPOO;

class Program
{

    private static void Main(string[] args)
    {
        // Criação de uma instância de PodCast
        PodCast meuPodcast = new PodCast("Tecnologia e Inovação", "João Silva");

        // Criação de uma instância de Episodio
        Episodio episodio1 = new Episodio(1, "Introdução à Programação", 30);
        Episodio episodio2 = new Episodio(2, "Avanços em Inteligência Artificial", 45);

        // Adicionando convidados ao episódio
        episodio1.AdicionarConvidados("Fernando Lemes");
        episodio1.AdicionarConvidados("Ana Maria");
        episodio2.AdicionarConvidados("Carlos Santos");
        episodio2.AdicionarConvidados("Mariana Lima");

        // Exibindo detalhes do episódio
        System.Console.WriteLine(episodio1.Resumo);
        System.Console.WriteLine(episodio2.Resumo);

        meuPodcast.AdicionarEpisodio(episodio2);
        meuPodcast.AdicionarEpisodio(episodio1);

        meuPodcast.ExibirDetalhes();



        /*Banda banda1 = new Banda("Queen");
        banda1.ExibirDiscografia();

        Album album1 = new Album("A night of the opera");

        Musica musica1 = new Musica("Love of my life", banda1, 60, true);


        album1.AdicionarMusica(musica1);

        banda1.AdicionarAlbum(album1);
        System.Console.WriteLine(musica1.DescricaoResumida);
        album1.ExibirMusicasAlbum();
        */



    }



}