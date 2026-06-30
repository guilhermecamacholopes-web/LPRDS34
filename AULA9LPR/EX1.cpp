#include <iostream>
#include <list>

using namespace std;

int main() {
    list<float> notas;
    float nota, soma = 0;

    // Cadastro das 5 notas
    for (int i = 1; i <= 5; i++) {
        cout << "Digite a " << i << "ª nota: ";
        cin >> nota;
        notas.push_back(nota);
    }

    // Inicializa maior e menor com a primeira nota
    float maior = notas.front();
    float menor = notas.front();

    // Percorre a lista
    for (float n : notas) {
        soma += n;

        if (n > maior)
            maior = n;

        if (n < menor)
            menor = n;
    }

    float media = soma / notas.size();

    // Exibe os resultados
    cout << "\nNotas cadastradas: ";
    for (float n : notas) {
        cout << n << " ";
    }

    cout << "\n\nMaior nota: " << maior;
    cout << "\nMenor nota: " << menor;
    cout << "\nMedia das notas: " << media << endl;

    return 0;
}