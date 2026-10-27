
using System;

class Produto
{
    public string nome;
    public double preco;
}

class Pedido
{
    public Produto produto;
    public int quantidade;
}

class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto();
        p1.nome = "Mouse";
        p1.preco = 50.00;

        Pedido pedido1 = new Pedido();
        pedido1.produto = p1;
        pedido1.quantidade = 3;

        double total = pedido1.produto.preco * pedido1.quantidade;

        Console.WriteLine("Produto: " + pedido1.produto.nome);
        Console.WriteLine("Quantidade: " + pedido1.quantidade);
        Console.WriteLine("Preço total: R$ " + total.ToString("F2"));
    }
}
