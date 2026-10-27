
using System;
using System.Collections.Generic;

class Aluno
{
    public string nome;
    public List<Matricula> matriculas = new List<Matricula>();

    public Aluno(string nome)
    {
        this.nome = nome;
    }

    public bool AdicionarMatricula(Turma turma, DateTime data)
    {
        // Verifica se o aluno ja esta matriculado nessa turma
        foreach (Matricula m in matriculas)
        {
            if (m.turma == turma)
            {
                Console.WriteLine(nome + " ja esta matriculado nessa turma.");
                return false;
            }
        }

        Matricula matricula = new Matricula(this, turma, data);
        matriculas.Add(matricula);
        turma.AdicionarMatricula(matricula);

        Console.WriteLine("Matricula realizada com sucesso!");
        return true;
    }
}

class Turma
{
    public string nome;
    public List<Matricula> matriculas = new List<Matricula>();

    public Turma(string nome)
    {
        this.nome = nome;
    }

    public void AdicionarMatricula(Matricula matricula)
    {
        matriculas.Add(matricula);
    }

    // Retorna a lista de alunos matriculados
    public List<Aluno> ListarAlunos()
    {
        List<Aluno> alunos = new List<Aluno>();

        foreach (Matricula m in matriculas)
        {
            alunos.Add(m.aluno);
        }

        return alunos;
    }
}

class Matricula
{
    public Aluno aluno;
    public Turma turma;
    public DateTime dataMatricula;

    public Matricula(Aluno aluno, Turma turma, DateTime dataMatricula)
    {
        this.aluno = aluno;
        this.turma = turma;
        this.dataMatricula = dataMatricula;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno("Joao");
        Aluno aluno2 = new Aluno("Maria");

        Turma turma1 = new Turma("Desenvolvimento de Sistemas");
        Turma turma2 = new Turma("Banco de Dados");

        DateTime hoje = DateTime.Today;

        // Matriculas dos alunos
        aluno1.AdicionarMatricula(turma1, hoje);
        aluno1.AdicionarMatricula(turma2, hoje);
        aluno2.AdicionarMatricula(turma1, hoje);

        // Tentativa de matricula duplicada
        aluno1.AdicionarMatricula(turma1, hoje);

        // Listar alunos da turma
        Console.WriteLine("\nAlunos da turma: " + turma1.nome);

        List<Aluno> alunos = turma1.ListarAlunos();

        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine(aluno.nome);
        }
    }
}
