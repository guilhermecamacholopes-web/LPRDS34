using System;

class Program
{
    static void Main(string[] args)
    {
        int codigo1, numero1;
        double valor1;

        int codigo2, numero2;
        double valor2;

        Console.Write("Código da peça 1: ");
        codigo1 = int.Parse(Console.ReadLine());

        Console.Write("Número de peças 1: ");
        numero1 = int.Parse(Console.ReadLine());

        Console.Write("Valor unitário da peça 1: ");
        valor1 = double.Parse(Console.ReadLine());

        Console.Write("Código da peça 2: ");
        codigo2 = int.Parse(Console.ReadLine());

        Console.Write("Número de peças 2: ");
        numero2 = int.Parse(Console.ReadLine());

        Console.Write("Valor unitário da peça 2: ");
        valor2 = double.Parse(Console.ReadLine());

        double total = (numero1 * valor1) + (numero2 * valor2);

        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));
    }
}