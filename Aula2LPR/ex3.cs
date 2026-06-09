using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int numfuncinonario;
        int hrst;
        double vphr , salario;

        // Leitura dos dados
        Console.Write("Digite o número do funcionário: ");
        numFuncionario = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de horas trabalhadas do funcionário : ");
        hrst = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor recebido por hora pelo funcionario: ");
        valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Cálculo do salário
        salario = hrst * vphr;

        // Exibição do resultado com duas casas decimais
        Console.WriteLine("NUMBER = " + numFuncionario);
        Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}