using System;

struct Heroi
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

class Program
{
    static Heroi[] herois = new Heroi[5];
    static Heroi[] equipe = new Heroi[3];

    static int qtdHerois = 0;
    static int qtdEquipe = 0;

    static void Main(string[] args)
    {
        menuPrincipal();
    }

    static void cadastrarHeroi()
    {
        if (qtdHerois >= 5)
        {
            Console.WriteLine("Limite de 5 heróis atingido!");
            return;
        }

        Console.WriteLine("\n=== CADASTRO DE HERÓI ===");

        Console.Write("Nome: ");
        herois[qtdHerois].Nome = Console.ReadLine();

        Console.Write("Poder: ");
        herois[qtdHerois].Poder = Console.ReadLine();

        Console.Write("Pontuação: ");
        herois[qtdHerois].Pontuacao = int.Parse(Console.ReadLine());

        qtdHerois++;

        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    static void selecionarEquipe()
    {
        if (qtdHerois < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis primeiro.");
            return;
        }

        qtdEquipe = 0;

        Console.WriteLine("\n=== HERÓIS DISPONÍVEIS ===");

        for (int i = 0; i < qtdHerois; i++)
        {
            Console.WriteLine($"{i} - {herois[i].Nome} | {herois[i].Poder} | {herois[i].Pontuacao} pontos");
        }

        Console.WriteLine("\nSelecione 3 heróis:");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Herói {i + 1}: ");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < qtdHerois)
            {
                equipe[i] = herois[indice];
                qtdEquipe++;
            }
            else
            {
                Console.WriteLine("Índice inválido!");
                i--;
            }
        }

        Console.WriteLine("Equipe criada com sucesso!");
    }

    static int calcularPontuacaoTotal()
    {
        int total = 0;

        for (int i = 0; i < qtdEquipe; i++)
        {
            total += equipe[i].Pontuacao;
        }

        return total;
    }

    static void exibirEquipe()
    {
        if (qtdEquipe == 0)
        {
            Console.WriteLine("Nenhuma equipe foi criada.");
            return;
        }

        Console.WriteLine("\n=== EQUIPE MARVEL ===");

        for (int i = 0; i < qtdEquipe; i++)
        {
            Console.WriteLine($"Herói: {equipe[i].Nome}");
            Console.WriteLine($"Poder: {equipe[i].Poder}");
            Console.WriteLine($"Pontuação: {equipe[i].Pontuacao}");
            Console.WriteLine("----------------------");
        }

        Console.WriteLine($"Pontuação Total: {calcularPontuacaoTotal()}");
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    break;

                case 2:
                    selecionarEquipe();
                    break;

                case 3:
                    exibirEquipe();
                    break;

                case 4:
                    Console.WriteLine("Encerrando programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 4);
    }
}