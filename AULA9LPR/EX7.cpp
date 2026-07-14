#include <iostream>
#include <map>
#include <string>

using namespace std;

int main()
{
    map<string, int> cidades;
    int x;

    cout << "Quantas cidades deseja cadastrar? ";
    cin >> x;
    cin.ignore();

    // Cadastro
    for (int i = 0; i < x; i++)
    {
        string nome;
        int populacao;

        cout << "\nNome da cidade: ";
        getline(cin, nome);

        cout << "Populacao: ";
        cin >> populacao;
        cin.ignore();

        cidades[nome] = populacao;
    }

    // Calcular média
    double soma = 0;

    for (auto cidade : cidades)
    {
        soma += cidade.second;
    }

    double media = soma / cidades.size();

    cout << "\nMedia da populacao: " << media << endl;

    // Cidades acima da média
    cout << "\nCidades com populacao acima da media:\n";

    for (auto cidade : cidades)
    {
        if (cidade.second > media)
        {
            cout << cidade.first << " - " << cidade.second << " habitantes" << endl;
        }
    }

    // Cidade mais populosa e menos populosa
    string maisPopulosa, menosPopulosa;
    int maior = -1;
    int menor = 1000000000;

    for (auto cidade : cidades)
    {
        if (cidade.second > maior)
        {
            maior = cidade.second;
            maisPopulosa = cidade.first;
        }

        if (cidade.second < menor)
        {
            menor = cidade.second;
            menosPopulosa = cidade.first;
        }
    }

    cout << "\nCidade mais populosa: " << maisPopulosa
         << " (" << maior << " habitantes)" << endl;

    cout << "Cidade menos populosa: " << menosPopulosa
         << " (" << menor << " habitantes)" << endl;

    // Remover cidades com população Y
    int y;

    cout << "\nDigite a populacao que deseja remover: ";
    cin >> y;

    for (auto it = cidades.begin(); it != cidades.end();)
    {
        if (it->second == y)
        {
            it = cidades.erase(it);
        }
        else
        {
            ++it;
        }
    }

    // Exibir dicionário atualizado
    cout << "\nDicionario atualizado:\n";

    for (auto cidade : cidades)
    {
        cout << cidade.first << " - " << cidade.second << " habitantes" << endl;
    }

    return 0;
}