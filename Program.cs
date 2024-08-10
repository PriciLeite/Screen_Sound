// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Runtime.Intrinsics.Arm;


// internal partial class Program
// {
//     private static void Main(string[] args)
//     {
//         //List<string> listaDasBandas = new List<string> { "U2", "Iron Maiden", "Beatles" };
//         Dictionary<string, List<int>> bandasRegistradas = new(StringComparer.OrdinalIgnoreCase);
//         bandasRegistradas.Add("Bon Jovi", new List<int> { 10, 9, 8 });
//         bandasRegistradas.Add("Beatles", new List<int> { });

//         void ExibirLogo()
//         {
//             Console.WriteLine("BEM-VINDO");
//             Console.WriteLine(@"
//     ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//     ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//     ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//     ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//     ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//     ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
//         }

//         ExibirLogo();
//         Console.WriteLine();

//         // Início: Mostrando as opções disponíveis.
//         void ExibirOpcoesDoMenu()
//         {
//             Console.WriteLine("Digite 1 para registrar uma banda");
//             Console.WriteLine("Digite 2 para mostrar todas as bandas");
//             Console.WriteLine("Digite 3 para avaliar uma banda");
//             Console.WriteLine("Digite 4 para exibir a média de uma banda");
//             Console.WriteLine("Digite 5 para sair:");

//             Console.Write("\n Digite sua opção: ");
//             string opcaoEscolhida = Console.ReadLine()!;
//             int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

//             switch (opcaoEscolhidaNumerica)
//             {
//                 case 1:
//                     RegistrarBanda();
//                     break;
//                 case 2:
//                     MostrarBandasRegistrada();
//                     break;
//                 case 3:
//                     AvaliarUmaBanda();
//                     break;
//                 case 4:
//                     ExibirMediaDaBanda();
//                     break;
//                 case 5:
//                     Console.WriteLine("Tchau! :)");
//                     break;
//                 default:
//                     Console.WriteLine("Nenhuma opção escolhida válida!");
//                     break;
//             }
//         }
//         ExibirOpcoesDoMenu();
//         Console.WriteLine();


//         // * Opção 1: Registando as bandas.
//         void RegistrarBanda()
//         {
//             Console.Clear();
//             ExibirTituloDaOpcao("Registrando sua Banda");
//             Console.WriteLine("Digite o nome da banda: ");
//             string nomeDaBanda = Console.ReadLine()!;
//             bandasRegistradas.Add(nomeDaBanda, new List<int>());
//             Console.WriteLine("\nGravando...");
//             Thread.Sleep(3000);
//             ExibirTituloDaOpcao($"A banda {nomeDaBanda} foi regritada com sucesso!");
//             Thread.Sleep(2000); //Aguardando
//             Console.Clear();

//             ExibirLogo();
//             ExibirOpcoesDoMenu();
//         }
//         RegistrarBanda();


//         // * Opção 2: Mostrando as bandas.
//         void MostrarBandasRegistrada()
//         {
//             Console.Clear();
//             ExibirTituloDaOpcao("TODAS AS BANDAS REGISTRADAS");

//             /* for (int i = 0; i < listaDasBandas.Count; i++)
//             {
//                 Console.WriteLine($"\nBanda {i + 1}: {listaDasBandas[i]}");
//             }
//             */
//             //Laço de repetição para exibir as bandas:
//             foreach (string banda in bandasRegistradas.Keys)
//             {
//                 Console.WriteLine($"Banda: {banda}");
//             }

//             Console.Write("\nDigite qualquer tecla para MENU PRINCIPAL: ");
//             Console.ReadKey(); //Qualquer tecla
//             Console.Clear();

//             ExibirLogo();
//             ExibirOpcoesDoMenu();
//         }


//         // * Opção 3: Avaliar uma banda.
//         void AvaliarUmaBanda()
//         {
//             Console.Clear();
//             ExibirTituloDaOpcao("AVALIAR BANDA");

//             // Qual banda deseja avaliar?
//             Console.Write("\nDigite qual banda deseja avaliar? ");
//             string nomeDaBanda = Console.ReadLine()!;
//             // A banda existe? Se existir atribuir nota!
//             if (bandasRegistradas.ContainsKey(nomeDaBanda))
//             {
//                 Console.Write($"\nQual sua nota para a banda {nomeDaBanda} ? ");
//                 int nota = int.Parse(Console.ReadLine()!);
//                 bandasRegistradas[nomeDaBanda].Add(nota);
//                 Console.Write($"Nota {nota} atribuida com sucesso para {nomeDaBanda}.");
//                 Console.WriteLine("\n RETORNANDO AO MENU PRINCIPAL...");
//                 Thread.Sleep(3000);
//                 Console.Clear();
//             }
//             // Se não, volta ao menu principal.        
//             else
//             {
//                 Console.WriteLine($"\nBanda {nomeDaBanda} não encontrado!");
//                 Console.Write("Digite uma tecla para Menu Príncipal: ");
//                 Console.ReadKey();
//                 Console.Clear();
//             }

//             ExibirLogo();
//             ExibirOpcoesDoMenu();
//         }



//         // * Opção 4: Exibir a média de uma banda.
//         void ExibirMediaDaBanda()
//         {
//             Console.Clear();
//             ExibirTituloDaOpcao("MÉDIA DA BANDA ESCOLHIDA");

//             // Qual o nome da banda para média ?
//             Console.Write("\nDigite o nome da banda para média: ");
//             string nomeDaBanda = Console.ReadLine()!;

//             // Se a banda está cadastrada, exibir a média.
//             if (bandasRegistradas.ContainsKey(nomeDaBanda))
//             {
//                 double mediaDaBanda = bandasRegistradas[nomeDaBanda].Average();
//                 Console.WriteLine($"\nA Média da banda {nomeDaBanda} é: {mediaDaBanda}");
//                 Console.WriteLine("\n RETORNANDO AO MENU PRINCIPAL...");
//                 Thread.Sleep(3000);
//             }
//             // Se não, essa banda não está cadastrada ou não possui nota.
//             else
//             {
//                 Console.WriteLine($"\nBanda {nomeDaBanda} não encontrado!");
//                 Console.Write("Digite uma tecla para Menu Príncipal: ");
//                 Console.ReadKey();

//             }
//             Console.Clear();
//             ExibirLogo();
//             ExibirOpcoesDoMenu();
//         }


//         /* Asteriscos: Ajustando exibição do título.*/
//         void ExibirTituloDaOpcao(string titulo)
//         {
//             //Ler a quantidade de letras:
//             int quantidadeDeLetras = titulo.Length;
//             // Inserindo os asterisco do tamanho da string titulo à esquerda:
//             string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
//             Console.WriteLine(asterisco);
//             Console.WriteLine(titulo);
//             Console.WriteLine(asterisco + "\n");
//         }
//     }
// }