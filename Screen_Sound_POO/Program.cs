using System;
using System.Security.Cryptography.X509Certificates;
using ScreenSound.ScreenSoundPOO;


class Program
{
    private static void Main(string[] args)
    {
        Banda bonJovi = new("Bon Jovi");
        bonJovi.AdicionarNota(10);
        bonJovi.AdicionarNota(8);
        bonJovi.AdicionarNota(6);

        Banda beatles = new("The Beatles");
        beatles.AdicionarNota(10);
        beatles.AdicionarNota(9);


        Dictionary<string, Banda> bandasRegistradas = new(StringComparer.OrdinalIgnoreCase);
        bandasRegistradas.Add(bonJovi.Nome, bonJovi);
        bandasRegistradas.Add(beatles.Nome, beatles);

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
            Console.WriteLine("Digite 2 para exibir todas as bandas");
            Console.WriteLine("Digite 3 para registrar um álbum");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair:");

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
                    RegistrarAlbum();
                    break;
                case 4:
                    AvaliarUmaBanda();
                    break;
                case 5:
                    ExibirMediaDaBanda();
                    break;
                case -1:
                    Console.WriteLine("Tchau! :)");
                    break;
                default:
                    Console.WriteLine("Nenhuma opção escolhida válida!");
                    break;
            }
        }
        ExibirOpcoesDoMenu();
        Console.WriteLine();


        // * Opção 1: Registando as bandas.
        void RegistrarBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("Registrar sua Banda");
            Console.WriteLine("Digite o nome da banda: ");

            string nomeDaBanda = Console.ReadLine()!;
            Banda banda = new(nomeDaBanda);
            bandasRegistradas.Add(nomeDaBanda, banda);

            Console.WriteLine("\nGravando...");
            Thread.Sleep(4000);
            ExibirTituloDaOpcao($"A banda {nomeDaBanda} foi regritada com sucesso!");
            Thread.Sleep(2000); //Aguardando
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

            //Laço de repetição para exibir as bandas:
            foreach (string banda in bandasRegistradas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }

            Console.Write("\nDigite qualquer tecla para MENU PRINCIPAL: ");
            Console.ReadKey(); //Qualquer tecla
            Console.Clear();

            ExibirLogo();
            ExibirOpcoesDoMenu();
        }


        // * Opção 3: Registando as bandas.
        void RegistrarAlbum()
        {
            Console.Clear();
            ExibirTituloDaOpcao("REGISTRANDO ÁLBUM\n");
            Console.Write("A qual banda pertence este álbum, Digite o nome aqui:  ");
            string nomeDaBanda = Console.ReadLine()!;

            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write($"Agora digite o título do álbum: ");
                string tituloAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeDaBanda];
                banda.AdicionarAlbum(new Album(tituloAlbum));

                ExibirTituloDaOpcao($"O álbum {tituloAlbum} da banda {nomeDaBanda} foi resgistrado com sucesso! :)");
                Thread.Sleep(4000);
                Console.Clear();
            }
            // Se não, volta ao menu principal.        
            else
            {
                Console.WriteLine($"\nBanda {nomeDaBanda} não encontrado!");
                Console.Write("Digite uma tecla para voltar ao menu inícial: ");
                Console.ReadKey();
                Console.Clear();
            }
            ExibirLogo();
            ExibirOpcoesDoMenu();
        }


        // * Opção 4: Avaliar uma banda.
        void AvaliarUmaBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("AVALIAR BANDA");

            // Qual banda deseja avaliar?
            Console.Write("\nDigite qual banda deseja avaliar? ");
            string nomeDaBanda = Console.ReadLine()!;

            // A banda existe? Se existir atribuir nota
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write($"\nQual sua nota para a banda {nomeDaBanda} ? ");
                int nota = int.Parse(Console.ReadLine()!);

                // pegando a banda do dicionário, se existir.
                Banda banda = bandasRegistradas[nomeDaBanda];
                banda.AdicionarNota(nota);
                Console.Write($"Nota {nota} atribuida com sucesso para {nomeDaBanda}.");
                Console.WriteLine("\n RETORNANDO AO MENU PRINCIPAL...");
                Thread.Sleep(3000);
                Console.Clear();
            }
            // Se não, volta ao menu principal.        
            else
            {
                Console.WriteLine($"\nBanda {nomeDaBanda} não encontrado!");
                Console.Write("Digite uma tecla para Menu Príncipal: ");
                Console.ReadKey();
                Console.Clear();
            }

            ExibirLogo();
            ExibirOpcoesDoMenu();
        }


        // * Opção 5: Exibir a média de uma banda.
        void ExibirMediaDaBanda()
        {
            Console.Clear();
            ExibirTituloDaOpcao("MÉDIA DA BANDA ESCOLHIDA");

            // Qual o nome da banda para média ?
            Console.Write("\nDigite o nome da banda para média de avaliação: ");
            string nomeDaBanda = Console.ReadLine()!;

            // Se a banda está cadastrada, exibir a média.
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                // pegando a banda do dicionário, se existir.
                Banda banda = bandasRegistradas[nomeDaBanda];

                Console.WriteLine($"\nA Média da banda {nomeDaBanda} é: ({banda.Media})");
                Console.WriteLine("\n RETORNANDO AO MENU PRINCIPAL...");
                Thread.Sleep(3000);
            }
            // Se não, essa banda não está cadastrada ou não possui nota.
            else
            {
                Console.WriteLine($"\nBanda {nomeDaBanda} não encontrado!");
                Console.Write("Digite uma tecla para Menu Príncipal: ");
                Console.ReadKey();

            }
            Console.Clear();
            ExibirLogo();
            ExibirOpcoesDoMenu();
        }


        /* Asteriscos: Ajustando exibição do título.*/
        void ExibirTituloDaOpcao(string titulo)
        {
            //Ler a quantidade de letras:
            int quantidadeDeLetras = titulo.Length;
            // Inserindo os asterisco do tamanho da string titulo à esquerda:
            string asterisco = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(asterisco);
            Console.WriteLine(titulo);
            Console.WriteLine(asterisco + "\n");
        }
    }


}



