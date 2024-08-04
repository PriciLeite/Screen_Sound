using System;
using System.Collections.Generic;


namespace ScreenSound.ScreenSoundPOO;
class Banda
{
    public string? Nome { get; set; }
    private List<Album> albums = new List<Album>();



    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        System.Console.WriteLine($"Discográfia da Banda {Nome}.");
        foreach (Album album in albums)
        {
            System.Console.WriteLine($"Álbum {album.Nome}");
        }
    }

}