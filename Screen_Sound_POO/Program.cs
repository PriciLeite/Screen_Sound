internal class Program
{


    static public int Somar(int a, int b) => a + b;

    private static void Main(string[] args)
    {
        var resultado1 = Somar(100, 100);
        System.Console.WriteLine($"Soma: {resultado1}");
    }
}