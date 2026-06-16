#include <iostream>
#include <string>

using namespace std;

struct Filme
{
    string Titulo;
    string Diretor;
    int AnoLancamento;
    int DuracaoMinutos;
};

int main()
{
    Filme filmes[3];

    // Cadastro dos filmes
    for (int i = 0; i < 3; i++)
    {
        cout << "\nFilme " << i + 1 << endl;

        cout << "Titulo: ";
        getline(cin, filmes[i].Titulo);

        cout << "Diretor: ";
        getline(cin, filmes[i].Diretor);

        cout << "Ano de Lancamento: ";
        cin >> filmes[i].AnoLancamento;

        cout << "Duracao (minutos): ";
        cin >> filmes[i].DuracaoMinutos;

        cin.ignore(); // Limpa o buffer do teclado
    }

    // Exibição dos filmes
    cout << "\n=== FILMES CADASTRADOS ===\n";

    for (int i = 0; i < 3; i++)
    {
        cout << "\nFilme " << i + 1 << endl;
        cout << "Titulo: " << filmes[i].Titulo << endl;
        cout << "Diretor: " << filmes[i].Diretor << endl;
        cout << "Ano de Lancamento: " << filmes[i].AnoLancamento << endl;
        cout << "Duracao: " << filmes[i].DuracaoMinutos << " minutos" << endl;
    }

    // Encontrar o filme mais antigo
    int indiceMaisAntigo = 0;

    for (int i = 1; i < 3; i++)
    {
        if (filmes[i].AnoLancamento < filmes[indiceMaisAntigo].AnoLancamento)
        {
            indiceMaisAntigo = i;
        }
    }

    cout << "\n=== FILME MAIS ANTIGO ===\n";
    cout << "Titulo: " << filmes[indiceMaisAntigo].Titulo << endl;
    cout << "Diretor: " << filmes[indiceMaisAntigo].Diretor << endl;
    cout << "Ano de Lancamento: " << filmes[indiceMaisAntigo].AnoLancamento << endl;

    return 0;
}