using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um numero: ");
        int numero = int.Parse(Console.ReadLine());

        int quadrado = numero * numero;
        int soma = 0;

        while (quadrado > 0)
        {
            soma += quadrado % 10; 
            quadrado /= 10;       
        }

        Console.WriteLine("Soma dos digitos do quadrado: " + soma);
    }
} 