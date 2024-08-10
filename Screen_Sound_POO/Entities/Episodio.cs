using System;
using System.Collections.Generic;


namespace ScreenSound.ScreenSoundPOO;
class Episodio
{
    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"\nEpisódio:{Ordem}\nTema:{Titulo}\nDuração:({Duracao}min)\nConvidados:{string.Join(", ", convidados)}.\n";
    public List<string> convidados { get; } = new();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }


}