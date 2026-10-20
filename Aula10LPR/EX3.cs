

using System;

class Aluno
{
    public int Matricula;
    public string Nome;
    public double Nota1;
    public double Nota2;
    public double NotaTrabalho;

    public double media()
    {
        return (Nota1 * 2.5 + Nota2 * 2.5 + NotaTrabalho * 2) / 7;
    }

    public double final()
    {
        if (media() < 60)
        {
            return 60 - media();
        }
        else
        {
            return 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno a = new Aluno();

        Console.Write("Digite a matricula: ");
        a.Matricula = int.Parse(Console.ReadLine());

        Console.Write("Digite o nome: ");
        a.Nome = Console.ReadLine();

        Console.Write("Digite a primeira nota: ");
        a.Nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        a.Nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota do trabalho: ");
        a.NotaTrabalho = double.Parse(Console.ReadLine());

        Console.WriteLine("\nMatricula: " + a.Matricula);
        Console.WriteLine("Nome: " + a.Nome);
        Console.WriteLine("Media final: " + a.media().ToString("F2"));

        if (a.final() > 0)
        {
            Console.WriteLine("Precisa tirar " + a.final().ToString("F2") + " na final.");
        }
        else
        {
            Console.WriteLine("Nao precisa fazer a prova final.");
        }
    }
}
