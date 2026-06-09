using System;

class Program
{
    static void Main()
    {
        int n, i = 0;
        int numero;
        int soma = 0;
        int contadorPares = 0;

        Console.Write("Quantos números serão digitados? ");
        n = int.Parse(Console.ReadLine());

        while (i < n)
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) 
            {
                soma += numero;
                contadorPares++;
            }

            i++;
        }

        if (contadorPares > 0)
        {
            double media = (double)soma / contadorPares;
            Console.WriteLine("Média dos pares: " + media);
        }
        else
        {
            Console.WriteLine("Nenhum número par foi digitado.");
        }
    }
}