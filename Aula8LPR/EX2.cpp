#include <iostream>
#include <string>

using namespace std;

struct Produto
{
    string Nome;
    int Codigo;
    float Preco;
    int Quantidade;
};

int main()
{
    Produto produtos[3];
    float totalEstoque = 0;

    for(int i = 0; i < 3; i++)
    {
        cout << "\nProduto " << i + 1 << endl;

        cout << "Nome: ";
        cin >> produtos[i].Nome;

        cout << "Codigo: ";
        cin >> produtos[i].Codigo;

        cout << "Preco: ";
        cin >> produtos[i].Preco;

        cout << "Quantidade: ";
        cin >> produtos[i].Quantidade;

        totalEstoque += produtos[i].Preco * produtos[i].Quantidade;
    }

    cout << "\nValor total em estoque: R$ " << totalEstoque << endl;

    return 0;
}