using System;

class Program
{
    static string nome1, nome2; 
    static int forca1, forca2;
    static int agilidade1, agilidade2;
    static int vida1, vida2;
    static int inteligencia1, inteligencia2;

    static int totalCadastrados = 0;

    static void cadastrarPersonagem()
    {
        if (totalCadastrados >= 2)
        {
            Console.WriteLine("Limite de personagens atingido!");
            return;
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Forca: ");
        int forca = int.Parse(Console.ReadLine());

        Console.Write("Agilidade: ");
        int agilidade = int.Parse(Console.ReadLine());

        Console.Write("Inteligência: ");
        int inteligencia = int.Parse(Console.ReadLine());

        Console.Write("Vida: ");
        int vida = int.Parse(Console.ReadLine());

        totalCadastrados++;

        if (totalCadastrados == 1)
        {
            nome1 = nome; forca1 = forca; agilidade1 = agilidade; inteligencia1 = inteligencia; vida1 = vida;
        }
        else if (totalCadastrados == 2)
        {
            nome2 = nome; forca2 = forca; agilidade2 = agilidade; inteligencia2 = inteligencia; vida2 = vida;
        }
    }

    static void batalha()
    {
        if (totalCadastrados < 2)
        {
            Console.WriteLine("Cadastre 2 personagens primeiro!");
            return;
        }

        int poder1 = vida1 + agilidade1;
        int poder2 = vida2 + agilidade2;

        Console.WriteLine("\n=== BATALHA  ===");

        Console.WriteLine($"{nome1} -> Vida: {vida1}, Agilidade: {agilidade1}, Poder: {poder1}");
        Console.WriteLine($"{nome2} -> Vida: {vida2}, Agilidade: {agilidade2}, Poder: {poder2}");

        if (poder1 > poder2)
            Console.WriteLine($"Vencedor: {nome1}");
        else if (poder2 > poder1)
            Console.WriteLine($"Vencedor: {nome2}");
        else
            Console.WriteLine("Empate!");
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("1 - Cadastrar Personagem");
            Console.WriteLine("2 - Iniciar Batalha");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: cadastrarPersonagem(); break;
                case 2: batalha(); break;
                case 0: Console.WriteLine("Saindo..."); break;
                default: Console.WriteLine("Opção inválida!"); break;
            }

        } while (opcao != 0);
    }

    static void Main()
    {
        menuPrincipal();
    
    }
}