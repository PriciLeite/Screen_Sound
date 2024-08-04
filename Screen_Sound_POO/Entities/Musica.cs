using System.Security.Cryptography.X509Certificates;
using System;
using System.Reflection.Metadata;

namespace ScreenSound.ScreenSoundPOO;

class Musica
{
    private string? nome;
    private string? artista;
    private int duracao;
    private bool disponivel;


    //null ou vazio ?
    // menor que 2 dígitos?
    public string? Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
            {
                throw new ArgumentException($"Nome da música: Insuficiente ou nulo não permitido.");
            }
            else
            {
                nome = value;
                System.Console.WriteLine($"Música: {nome}");
            }
        }

    }


    //null ou vazio ?
    // menor que 2 dígitos?
    public string? Artista
    {
        get => artista;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
            {
                throw new ArgumentException($"Nome do Artista: Insuficiente ou nulo não permitido.");
            }
            else
            {
                artista = value;
                System.Console.WriteLine($"Artista: {Artista}");
            }
        }
    }


    //valor positivo?
    // Duração máxima    
    public int Duracao
    {
        get => duracao;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("A duração da música deve ser um valor positivo.", nameof(value));
            }
            if (value > 3600) // Exemplo: duração máxima de 1 hora (3600 segundos)
            {
                throw new ArgumentException("A duração da música não pode exceder 1 hora.", nameof(value));
            }
            else
            {
                duracao = value;
                System.Console.WriteLine($"Duração: {Duracao} min");
            }
        }
    }

    public bool Disponivel
    {
        get => disponivel;
        set
        {
            disponivel = value;
            System.Console.WriteLine(disponivel ? "Música disponível." : "Música Indisponível.");
        }

    }
    public string DescricaoResumida => $"A mísuca {Nome} pertence a banda {Artista}";




    public void ExibirFichaTecnica()
    {
        //System.Console.WriteLine($"Música: {Nome}");
        //System.Console.WriteLine($"Artista: {Artista}");
        //System.Console.WriteLine($"Duração: {Duracao} min");
        //System.Console.WriteLine($"Disponível ? {Disponivel}");
    }


}