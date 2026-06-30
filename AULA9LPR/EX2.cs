using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());

        List<string> nomes = new List<string>();
        int maior = 0;

        // Leitura dos nomes
        for (int i = 0; i < x; i++)
        {
            string nome = Console.ReadLine();
            nomes.Add(nome);

            if (nome.Length > maior)
                maior = nome.Length;
        }

        bool[] usado = new bool[x];

        while (true)
        {
            bool encontrou = false;
            bool primeiro = true;

            for (int tam = 1; tam <= maior; tam++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (!usado[i] && nomes[i].Length == tam)
                    {
                        if (!primeiro)
                            Console.Write(", ");

                        Console.Write(nomes[i]);

                        usado[i] = true;
                        primeiro = false;
                        encontrou = true;
                        break; // Apenas um nome de cada tamanho por linha
                    }
                }
            }

            if (!encontrou)
                break;

            Console.WriteLine();
        }
    }
}