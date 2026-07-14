using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> jogos = new Dictionary<string, string>();

        Console.WriteLine("=== Cadastro de Jogos ===");

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("\nDigite o nome do jogo: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o gênero do jogo: ");
            string genero = Console.ReadLine();

            jogos[nome] = genero;
        }

        Console.WriteLine("\n=== Consulta de Jogo ===");
        Console.Write("Digite o nome do jogo que deseja pesquisar: ");
        string pesquisa = Console.ReadLine();

        if (jogos.ContainsKey(pesquisa))
        {
            Console.WriteLine("Gênero: " + jogos[pesquisa]);
        }
        else
        {
            Console.WriteLine("Jogo não cadastrado.");
        }

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}