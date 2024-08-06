using System.Security.Cryptography.X509Certificates;
using System;
using System.Reflection.Metadata;

namespace ScreenSound.ScreenSoundPOO;

class Musica
{
    private string? nome;
    private Banda Banda { get; }
    private int duracao;
    private bool disponivel;


    public Musica(string? nome, Banda banda, int duracao = 0, bool disponivel = false)
    {
        this.Nome = nome;
        this.Banda = banda;
        this.Duracao = duracao;
        this.Disponivel = disponivel;
    }


    public string? Nome
    {
        get => nome;
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 2)
            {
                throw new ArgumentException($"Nome da música: Insuficiente ou nulo não permitido.");
            }
            nome = value;
            System.Console.WriteLine($"Música: {Nome}");
        }
    }


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
            duracao = value;
            System.Console.WriteLine($"Duração: {Duracao} sec");

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

    public string DescricaoResumida => $"\nA música {Nome} pertence a banda {Banda.Nome}.";


    public override string ToString()
    {
        return $"\nNome: {nome}, \nArtista: {Banda.Nome}, \nDuração: {duracao}, \nDisponível: {disponivel}";
    }



}