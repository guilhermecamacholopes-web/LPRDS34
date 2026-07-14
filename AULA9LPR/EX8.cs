using System;
using System.Collections.Generic;
using System.Linq;

struct Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;
    public int Quantidade;
}

class Program
{
    static Dictionary<int, Livro> livros = new Dictionary<int, Livro>();

    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.WriteLine("\n===== BIBLIOTECA =====");
            Console.WriteLine("1 - Cadastrar Livro");
            Console.WriteLine("2 - Buscar Livro");
            Console.WriteLine("3 - Emprestar Livro");
            Console.WriteLine("4 - Exibir Relatório");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarLivro();
                    break;

                case 2:
                    BuscarLivro();
                    break;

                case 3:
                    EmprestarLivro();
                    break;

                case 4:
                    ExibirRelatorio();
                    break;
            }

        } while (opcao != 0);
    }

    static void CadastrarLivro()
    {
        if (livros.Count >= 10)
        {
            Console.WriteLine("Limite de 10 livros atingido!");
            return;
        }

        Livro livro = new Livro();

        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Título: ");
        livro.Titulo = Console.ReadLine();

        Console.Write("Autor: ");
        livro.Autor = Console.ReadLine();

        Console.Write("Ano de publicação: ");
        livro.Ano = int.Parse(Console.ReadLine());

        Console.Write("Quantidade disponível: ");
        livro.Quantidade = int.Parse(Console.ReadLine());

        livros[codigo] = livro;

        Console.WriteLine("Livro cadastrado!");
    }

    static void BuscarLivro()
    {
        Console.Write("Digite o código: ");
        int codigo = int.Parse(Console.ReadLine());

        if (livros.ContainsKey(codigo))
        {
            Livro l = livros[codigo];

            Console.WriteLine("\nTítulo: " + l.Titulo);
            Console.WriteLine("Autor: " + l.Autor);
            Console.WriteLine("Ano: " + l.Ano);
            Console.WriteLine("Quantidade: " + l.Quantidade);
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void EmprestarLivro()
    {
        Console.Write("Código do livro: ");
        int codigo = int.Parse(Console.ReadLine());

        if (livros.ContainsKey(codigo))
        {
            Livro l = livros[codigo];

            if (l.Quantidade > 0)
            {
                l.Quantidade--;
                livros[codigo] = l;

                Console.WriteLine("Empréstimo realizado!");
            }
            else
            {
                Console.WriteLine("Não há exemplares disponíveis.");
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado.");
        }
    }

    static void ExibirRelatorio()
    {
        if (livros.Count == 0)
        {
            Console.WriteLine("Nenhum livro cadastrado.");
            return;
        }

        Console.WriteLine("\n===== RELATÓRIO =====");

        Console.WriteLine("Total de livros cadastrados: " + livros.Count);

        Livro antigo = livros.Values.First();
        Livro maiorQtd = livros.Values.First();

        foreach (Livro l in livros.Values)
        {
            if (l.Ano < antigo.Ano)
                antigo = l;

            if (l.Quantidade > maiorQtd.Quantidade)
                maiorQtd = l;
        }

        Console.WriteLine("\nLivro mais antigo:");
        Console.WriteLine(antigo.Titulo + " (" + antigo.Ano + ")");

        Console.WriteLine("\nLivro com maior quantidade disponível:");
        Console.WriteLine(maiorQtd.Titulo + " (" + maiorQtd.Quantidade + " exemplares)");

        Console.WriteLine("\nLivros por autor:");

        Dictionary<string, int> autores = new Dictionary<string, int>();

        foreach (Livro l in livros.Values)
        {
            if (autores.ContainsKey(l.Autor))
                autores[l.Autor]++;
            else
                autores[l.Autor] = 1;
        }

        foreach (var autor in autores)
        {
            Console.WriteLine(autor.Key + ": " + autor.Value + " livro(s)");
        }
    }
}