using System;
using System.Collections.Generic;


namespace ScreenSound.ScreenSoundPOO;

class Album
{
    //Músicas pertencem ao Albúm:
    private List<Musica> musicas = new List<Musica>();
    private string? nome;
    //private int duracaoTotal;

    public string? Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
            {
                throw new ArgumentException($"O nome do álbum deve ter pelo menos 2 caracteres, nameof(value)");
            }
            else
            {
                nome = value;
                System.Console.WriteLine($"\nÁlbum: {nome}");
            }
        }
    }

    // Para adiconar:
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    // Para Exibir: config. em Músicas.
    public void ExibirMusicasAlbum()
    {
        //validar:
        if (musicas == null || musicas.Count == 0)
        {
            System.Console.WriteLine($"Não há músicas no álbum.");
        }

        System.Console.WriteLine($"\n***Músicas do Álbum {nome}***");
        musicas?.ForEach(musica => System.Console.WriteLine(musica));
    }


}