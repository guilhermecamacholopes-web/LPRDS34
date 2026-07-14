#include <iostream>
#include <map>
#include <string>

using namespace std;

int main()
{
    map<string, int> pessoas;
    int x;

    cout << "Quantas pessoas deseja cadastrar? ";
    cin >> x;
    cin.ignore();

    // Cadastro
    for (int i = 0; i < x; i++)
    {
        string nome;
        int idade;

        cout << "\nNome: ";
        getline(cin, nome);

        cout << "Idade: ";
        cin >> idade;
        cin.ignore();

        pessoas[nome] = idade;
    }

    // Cálculo da média
    double soma = 0;

    for (auto p : pessoas)
    {
        soma += p.second;
    }

    double media = soma / pessoas.size();

    cout << "\nMedia das idades: " << media << endl;

    // Pessoas acima da média
    cout << "\nPessoas com idade acima da media:\n";

    for (auto p : pessoas)
    {
        if (p.second > media)
        {
            cout << p.first << " - " << p.second << " anos" << endl;
        }
    }

    // Encontrar mais velho e mais novo
    string maisVelho, maisNovo;
    int idadeMaior = -1;
    int idadeMenor = 200;

    for (auto p : pessoas)
    {
        if (p.second > idadeMaior)
        {
            idadeMaior = p.second;
            maisVelho = p.first;
        }

        if (p.second < idadeMenor)
        {
            idadeMenor = p.second;
            maisNovo = p.first;
        }
    }

    cout << "\nPessoa mais velha: " << maisVelho
         << " (" << idadeMaior << " anos)" << endl;

    cout << "Pessoa mais nova: " << maisNovo
         << " (" << idadeMenor << " anos)" << endl;

    // Remover pessoas com idade Y
    int y;

    cout << "\nDigite a idade que deseja remover: ";
    cin >> y;

    for (auto it = pessoas.begin(); it != pessoas.end();)
    {
        if (it->second == y)
        {
            it = pessoas.erase(it);
        }
        else
        {
            ++it;
        }
    }

    // Exibir dicionário atualizado
    cout << "\nDicionario atualizado:\n";

    for (auto p : pessoas)
    {
        cout << p.first << " - " << p.second << " anos" << endl;
    }

    return 0;
}