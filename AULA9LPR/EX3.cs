using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Random random = new Random();
        List<int> numeros = new List<int>();

        // Gerar 100 números aleatórios de 1 a 100
        for (int i = 0; i < 100; i++)
        {
            numeros.Add(random.Next(1, 101));
        }

        // Ordenar em ordem crescente
        numeros.Sort();

        Console.WriteLine("Lista ordenada:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine("\n");

        // Remover números pares
        numeros.RemoveAll(n => n % 2 == 0);

        Console.WriteLine("Lista sem os números pares:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine("\n");

        // Verificar números repetidos
        Console.WriteLine("Números repetidos:");

        Dictionary<int, int> contagem = new Dictionary<int, int>();

        foreach (int n in numeros)
        {
            if (contagem.ContainsKey(n))
                contagem[n]++;
            else
                contagem[n] = 1;
        }

        bool encontrou = false;

        foreach (var item in contagem)
        {
            if (item.Value > 1)
            {
                Console.WriteLine(item.Key + " aparece " + item.Value + " vezes.");
                encontrou = true;
            }
        }

        if (!encontrou)
        {
            Console.WriteLine("Não existem números repetidos.");
        }
    }
}