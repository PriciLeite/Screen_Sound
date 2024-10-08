using System;
using System.Collections.Generic;
using System.Linq;


namespace ScreenSound.ScreenSoundPOO;
class PodCast
{

    public string Nome { get; }
    public string Host { get; }
    public int TotalDeEpisodios => episodios.Count;
    private List<Episodio> episodios { get; } = new();

    public PodCast(string nome, string host)
    {
        this.Nome = nome;
        this.Host = host;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\n*** PodCast: {Nome} apresentado por {Host}***\n");
        Console.WriteLine($"Total de Episódios: {TotalDeEpisodios}");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            System.Console.WriteLine($"{episodio.Resumo}");
        }
        Console.WriteLine($"\n\nSão {TotalDeEpisodios} episódios para aproveitar.\n");
    }
}


