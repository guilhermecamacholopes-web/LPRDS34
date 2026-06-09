using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha sua classe:");
        Console.WriteLine("Guerreira, Mago ou Arqueira");

        string classe = Console.ReadLine().ToLower();

        if (classe == "guerreira")
        {
            Console.WriteLine("Guerreira:");
            Console.WriteLine("Habilidades: Ataque Pesado, Defesa Total");
        }
        else if (classe == "mago")
        {
            Console.WriteLine("Mago:");
            Console.WriteLine("Habilidades: Bola de Fogo, Escudo de Gelo");
        }
        else if (classe == "arqueira")
        {
            Console.WriteLine("Arqueira:");
            Console.WriteLine("Habilidades: Flecha Precisa, Disparo Triplo");
        }
        else
        {
            Console.WriteLine("Classe inválida!");
        }
    }
}