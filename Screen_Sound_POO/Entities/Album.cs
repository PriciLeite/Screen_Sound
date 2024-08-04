using System;
using System.Collections.Generic;
using System.Linq;


namespace ScreenSound.ScreenSoundPOO;

class Album
{
    private string? nome;
    public int DuracaoDoAlbum => musicas.Sum(musica => musica.Duracao);
    //Músicas pertencem ao Albúm:
    private List<Musica> musicas = new List<Musica>();


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

        System.Console.WriteLine($"\nPara ouvir este álbum você precisa de: {DuracaoDoAlbum} min");
    }

}