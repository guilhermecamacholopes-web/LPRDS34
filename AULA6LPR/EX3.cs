using System;

class Program
{
         static string nome1, nome2, nome3, nome4, nome5;
    static string poder1, poder2, poder3, poder4, poder5;
    static int pont1, pont2, pont3, pont4, pont5;

    static string eqNome1, eqNome2, eqNome3;
    static string eqPoder1, eqPoder2, eqPoder3;
    static int eqPont1, eqPont2, eqPont3;

    static int totalCadastrados = 0;

    static void cadastrarHeroi()
    {
        if (totalCadastrados >= 5)
        {
            Console.WriteLine("Limite de heróis atingido!");
            return;
        }

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Poder: ");
        string poder = Console.ReadLine();

        Console.Write("Pontuação: ");
        int pont = int.Parse(Console.ReadLine());

        totalCadastrados++;

        if (totalCadastrados == 1) { nome1 = nome; poder1 = poder; pont1 = pont; }
        else if (totalCadastrados == 2) { nome2 = nome; poder2 = poder; pont2 = pont; }
        else if (totalCadastrados == 3) { nome3 = nome; poder3 = poder; pont3 = pont; }
        else if (totalCadastrados == 4) { nome4 = nome; poder4 = poder; pont4 = pont; }
        else if (totalCadastrados == 5) { nome5 = nome; poder5 = poder; pont5 = pont; }
    }

    static void selecionarEquipe()
    {
        if (totalCadastrados < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis!");
            return;
        }

        Console.WriteLine("\nHeróis disponíveis:");

        if (totalCadastrados >= 1) Console.WriteLine("1 - " + nome1);
        if (totalCadastrados >= 2) Console.WriteLine("2 - " + nome2);
        if (totalCadastrados >= 3) Console.WriteLine("3 - " + nome3);
        if (totalCadastrados >= 4) Console.WriteLine("4 - " + nome4);
        if (totalCadastrados >= 5) Console.WriteLine("5 - " + nome5);

        Console.WriteLine("Escolha 3 heróis (número):");

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Escolha " + i + ": ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1) { salvarEquipe(i, nome1, poder1, pont1); }
            else if (escolha == 2) { salvarEquipe(i, nome2, poder2, pont2); }
            else if (escolha == 3) { salvarEquipe(i, nome3, poder3, pont3); }
            else if (escolha == 4) { salvarEquipe(i, nome4, poder4, pont4); }
            else if (escolha == 5) { salvarEquipe(i, nome5, poder5, pont5); }
        }
    }

    static void salvarEquipe(int pos, string nome, string poder, int pont)
    {
        if (pos == 1) { eqNome1 = nome; eqPoder1 = poder; eqPont1 = pont; }
        else if (pos == 2) { eqNome2 = nome; eqPoder2 = poder; eqPont2 = pont; }
        else if (pos == 3) { eqNome3 = nome; eqPoder3 = poder; eqPont3 = pont; }
    }
    static int calcularPontuacaoTotal()
    {
        return eqPont1 + eqPont2 + eqPont3;
    }

    static void exibirEquipe()
    {
        Console.WriteLine("\nEquipe escolhida:");

        Console.WriteLine(eqNome1 + " - " + eqPoder1 + " - " + eqPont1);
        Console.WriteLine(eqNome2 + " - " + eqPoder2 + " - " + eqPont2);
        Console.WriteLine(eqNome3 + " - " + eqPoder3 + " - " + eqPont3);

        Console.WriteLine("Pontuação total: " + calcularPontuacaoTotal());
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n==== MENU ====");
            Console.WriteLine("1 - Cadastrar herói");
            Console.WriteLine("2 - Selecionar equipe");
            Console.WriteLine("3 - Exibir equipe");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: cadastrarHeroi(); break;
                case 2: selecionarEquipe(); break;
                case 3: exibirEquipe(); break;
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