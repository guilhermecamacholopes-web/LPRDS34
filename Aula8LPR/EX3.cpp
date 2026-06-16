#include <iostream>
#include <string>

using namespace std;

struct Livro
{
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    float Preco;
};

int main()
{
    Livro livros[3];

    float precoTotal = 0;
    int totalPaginas = 0;

    for (int i = 0; i < 3; i++)
    {
        cout << "\nLivro " << i + 1 << endl;

        cout << "Titulo: ";
        getline(cin, livros[i].Titulo);

        cout << "Autor: ";
        getline(cin, livros[i].Autor);

        cout << "Ano de Publicacao: ";
        cin >> livros[i].AnoPublicacao;

        cout << "Numero de Paginas: ";
        cin >> livros[i].NumeroPaginas;

        cout << "Preco: ";
        cin >> livros[i].Preco;

        cin.ignore(); // Limpa o buffer

        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;
    }

    float mediaPaginas = (float)totalPaginas / 3;

    cout << "\n=== RESULTADOS ===" << endl;
    cout << "Preco total dos livros: R$ " << precoTotal << endl;
    cout << "Media de paginas: " << mediaPaginas << endl;

    return 0;
}