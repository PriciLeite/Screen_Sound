using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;


//List<string> listaDasBandas = new List<string> { "U2", "Iron Maiden", "Beatles" };
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Bon Jovin", new List<int> { 10, 9, 8 });
bandasRegistradas.Add("Beatles", new List<int> { });

void ExibirLogo()
{
    Console.WriteLine("BEM-VINDO");
    Console.WriteLine(@"
    ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
    ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
    ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
    ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
    ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
    ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
}

ExibirLogo();
Console.WriteLine();

// Início: Mostrando as opções disponíveis.
void ExibirOpcoesDoMenu()
{
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite 5 para sair:");

    Console.Write("\n Digite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarBandasRegistrada();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
            break;
        case 5:
            Console.WriteLine("Tchau! :)");
            break;
        default:
            Console.WriteLine("Nenhuma opção escolhida válida!");
            break;
    }
}
ExibirOpcoesDoMenu();
System.Console.WriteLine();


// * Opção 1: Registando as bandas.
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrando sua Banda");
    Console.WriteLine("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    System.Console.WriteLine("\nGravando...");
    Thread.Sleep(3000);
    ExibirTituloDaOpcao($"A banda {nomeDaBanda} foi regritada com sucesso!");
    Thread.Sleep(4000); //Aguardando
    Console.Clear();

    ExibirLogo();
    ExibirOpcoesDoMenu();
}
RegistrarBanda();


// * Opção 2: Mostrando as bandas.
void MostrarBandasRegistrada()
{
    Console.Clear();
    ExibirTituloDaOpcao("TODAS AS BANDAS REGISTRADAS");

    /* for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"\nBanda {i + 1}: {listaDasBandas[i]}");
    }
    */
    //Laço de repetição para exibir as bandas:
    foreach (string banda in bandasRegistradas.Keys)
    {
        System.Console.WriteLine($"Banda: {banda}");
    }

    Console.Write("\nDigite qualquer tecla para MENU PRINCIPAL: ");
    Console.ReadKey(); //Qualquer tecla
    Console.Clear();

    ExibirLogo();
    ExibirOpcoesDoMenu();
}


// * Opção 3: Avaliar uma banda.
void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("AVALIAR BANDA");

    // Qual banda deseja avaliar?
    System.Console.Write("\nDigite qual banda deseja avaliar? ");
    string nomeDaBanda = Console.ReadLine()!;
    // A banda existe? Se existir atribuir nota!
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        System.Console.Write($"Qual sua nota para a banda {nomeDaBanda} ? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        System.Console.Write($"Nota {nota} atribuida com sucesso para {nomeDaBanda}.");
        Thread.Sleep(4000);
        Console.Clear();

    }
    // Se não, volta ao menu principal.        
    else
    {
        System.Console.WriteLine($"\nBanda {nomeDaBanda} não encontrado!");
        System.Console.Write("Digite uma tecla para Menu Príncipal: ");
        Console.ReadKey();
        Console.Clear();
    }

    ExibirLogo();
    ExibirOpcoesDoMenu();


}



// * Opção 4: Exibir a média de uma banda.


/* Asteriscos: Ajustando exibição do título.*/
void ExibirTituloDaOpcao(string titulo)
{
    //Ler a quantidade de letras:
    int quantidadeDeLetras = titulo.Length;
    // Inserindo os asterisco do tamanho da string titulo à esquerda:
    string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
    System.Console.WriteLine(asterisco);
    System.Console.WriteLine(titulo);
    System.Console.WriteLine(asterisco + "\n");
}
