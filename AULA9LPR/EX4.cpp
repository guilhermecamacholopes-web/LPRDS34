#include <iostream>
#include <vector>
#include <algorithm>
#include <map>
using namespace std;

struct Piloto
{
    string nome;
    string equipe;
    int pontuacao;
};

vector<Piloto> pilotos;

void CadastrarPiloto()
{
    Piloto p;

    cout << "Nome: ";
    cin >> p.nome;

    cout << "Equipe: ";
    cin >> p.equipe;

    cout << "Pontuacao: ";
    cin >> p.pontuacao;

    pilotos.push_back(p);
}

void ExibirRanking()
{
    vector<Piloto> ranking = pilotos;

    sort(ranking.begin(), ranking.end(), [](Piloto a, Piloto b)
    {
        return a.pontuacao > b.pontuacao;
    });

    cout << "\n===== RANKING =====\n";

    for (int i = 0; i < ranking.size(); i++)
    {
        cout << i + 1 << "º - "
             << ranking[i].nome << " | "
             << ranking[i].equipe << " | "
             << ranking[i].pontuacao << " pontos" << endl;
    }
}

void CalcularPontuacaoMedia()
{
    int soma = 0;

    for (int i = 0; i < pilotos.size(); i++)
    {
        soma += pilotos[i].pontuacao;
    }

    double media = (double)soma / pilotos.size();

    int acimaMedia = 0;

    for (int i = 0; i < pilotos.size(); i++)
    {
        if (pilotos[i].pontuacao > media)
            acimaMedia++;
    }

    cout << "\nMedia de pontos: " << media << endl;
    cout << "Pilotos acima da media: " << acimaMedia << endl;
}

void ExibirMelhorEquipe()
{
    map<string, int> equipes;

    for (int i = 0; i < pilotos.size(); i++)
    {
        equipes[pilotos[i].equipe] += pilotos[i].pontuacao;
    }

    string melhorEquipe;
    int maiorPontuacao = 0;

    for (auto e : equipes)
    {
        if (e.second > maiorPontuacao)
        {
            maiorPontuacao = e.second;
            melhorEquipe = e.first;
        }
    }

    cout << "\n===== MELHOR EQUIPE =====\n";
    cout << "Equipe: " << melhorEquipe << endl;
    cout << "Total de pontos: " << maiorPontuacao << endl;
}

int main()
{
    cout << "Cadastro de 10 pilotos\n\n";

    for (int i = 0; i < 10; i++)
    {
        cout << "Piloto " << i + 1 << endl;
        CadastrarPiloto();
        cout << endl;
    }

    ExibirRanking();
    CalcularPontuacaoMedia();
    ExibirMelhorEquipe();

    return 0;
}