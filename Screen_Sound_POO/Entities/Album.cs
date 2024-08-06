using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;


namespace ScreenSound.ScreenSoundPOO;

class Album
{
    private string? nome;
    public List<Musica> musicas = new List<Musica>();


    public Album(string? nome)
    {
        this.nome = nome;
    }

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



    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);


    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasAlbum()
    {
        //validar:
        if (musicas == null || musicas.Count == 0)
        {
            System.Console.WriteLine($"Não há músicas no álbum.");
        }

        System.Console.WriteLine($"\n***Músicas do Álbum {nome}***");
        musicas?.ForEach(musica => System.Console.WriteLine(musica));

        System.Console.WriteLine($"\nDuração total do Álbum: {DuracaoTotal} min");
    }

}