using System;
using System.Collections.Generic;

namespace ScreenSound.ScreenSoundPOO;
class Banda
{

    private List<Album> albuns = new List<Album>();
    private List<int> notas = new List<int>();

    public Banda(string nome)
    {
        this.Nome = nome;
    }

    public string Nome { get; }
    public double Media => notas.Average();
    public List<Album> Albuns => albuns;

    public void AdicionarNota(int nota)
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