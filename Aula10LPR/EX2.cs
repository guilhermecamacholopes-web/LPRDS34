
using System;

class Funcionario
{
    public string Nome;
    public double SalarioBruto;
    public double Imposto;

    public double SalarioLiquido()
    {
        return SalarioBruto - Imposto;
    }

    public void MostrarDados()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Salario liquido: " + SalarioLiquido().ToString("F2"));
    }

    public void AumentarSalario(double porcentagem)
    {
        SalarioBruto += SalarioBruto * porcentagem / 100;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario();

        Console.Write("Digite o nome do funcionario: ");
        f.Nome = Console.ReadLine();

        Console.Write("Digite o salario bruto: ");
        f.SalarioBruto = double.Parse(Console.ReadLine());

        if (f.SalarioBruto <= 2000)
        {
            f.Imposto = f.SalarioBruto * 0.10;
        }
        else if (f.SalarioBruto <= 3000)
        {
            f.Imposto = f.SalarioBruto * 0.15;
        }
        else
        {
            f.Imposto = f.SalarioBruto * 0.20;
        }

        Console.WriteLine();
        f.MostrarDados();

        Console.Write("\nDigite a porcentagem de aumento: ");
        double porcentagem = double.Parse(Console.ReadLine());

        f.AumentarSalario(porcentagem);

        Console.WriteLine("\nDados atualizados:");
        f.MostrarDados();
    }
}
