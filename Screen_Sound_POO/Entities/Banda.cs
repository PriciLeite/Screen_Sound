using System;
using System.Collections.Generic;

namespace ScreenSound.ScreenSoundPOO;
class Banda
{

    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public string Nome { get; }

    public Banda(string nome)
    {
        this.Nome = nome;
    }

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public List<Album> Albuns => albuns;

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        System.Console.WriteLine($"Discográfia da Banda {Nome}.");
        foreach (Album album in albuns)
        {
            System.Console.WriteLine($"Álbum {album.Nome}");
        }
    }

}