using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
       

        Console.Write("Digite um numero inteiro: ");
        numero = int.Parse(Console.ReadLine());
 
          if (numero % 2 == 0)
        {
            Console.WriteLine(" O numero digitado e par " );
        }
       
       else
       
       {
        Console.WriteLine(" O numero digitado e impar " );
       }
    
    
    
    
    }
}