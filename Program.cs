using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;


internal class Program
{
    private static void Main(string[] args)
    {
        List<string> listaDasBandas = new List<string> { "U2", "Iron Maiden", "Beatles" };

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
            Console.WriteLine("Digite 0 para sair:");

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
                    Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
                    break;
                case 4:
                    Console.WriteLine("Você digitou a opção: " + opcaoEscolhidaNumerica);
                    break;
                case 0:
                    Console.WriteLine("Tchau! :) ");
                    break;
                default:
                    Console.WriteLine("Nenhuma opção escolhida válida!");
                    break;

            }
        }
        ExibirOpcoesDoMenu();
        Console.WriteLine();

        // Opção 1: Registando as bandas.
        void RegistrarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registrando sua Banda");
            Console.WriteLine("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;
            listaDasBandas.Add(nomeDaBanda);
            ExibirTituloDaOpcao($"A banda {nomeDaBanda} foi regritada com sucesso!");
            Thread.Sleep(2000); //Aguardando
            Console.Clear();

            ExibirLogo();
            ExibirOpcoesDoMenu();
        }
        RegistrarBanda();


        // Opção 2: Mostrando as bandas.
        void MostrarBandasRegistrada()
        {
            Console.Clear();
            ExibirTituloDaOpcao("TODAS AS BANDAS REGISTRADAS");

            //Laço de repetição para exibir as bandas:
            for (int i = 0; i < listaDasBandas.Count; i++)
            {
                Console.WriteLine($"\nBanda {i + 1}: {listaDasBandas[i]}");
            }

            Console.Write("\nDigite qualquer tecla para MENU PRINCIPAL: ");
            Console.ReadKey(); //Qualquer tecla
            Console.Clear();

            ExibirLogo();
            ExibirOpcoesDoMenu();
        }

        // Opção 3: Avaliar uma banda.




        // Asteriscos: Ajustando exibição do título.
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



    }
}