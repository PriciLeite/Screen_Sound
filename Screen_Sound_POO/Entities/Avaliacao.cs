class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
        this.Nota = nota;
    }

    // static para não ser necessário instanciar o método como novo objeto.
    // Chama apenas pelo nome usual do método (Avaliacao).  
    public static Avaliacao Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }


}