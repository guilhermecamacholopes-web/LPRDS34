#include <iostream>
#include <vector>
using namespace std;

int main() {

    vector<int> vetor(10);
    vector<int> pares;
    vector<int> impares;

    // Leitura dos números
    for(int i = 0; i < 10; i++) {
        cin >> vetor[i];

        // Verifica se é par ou ímpar
        if(vetor[i] % 2 == 0) {
            pares.push_back(vetor[i]);
        }
        else {
            impares.push_back(vetor[i]);
        }
    }

    // Mostrar pares
    cout << "PAR: ";
    for(int i = 0; i < pares.size(); i++) {
        cout << pares[i] << " ";
    }

    cout << endl;

    // Mostrar ímpares
    cout << "IMPAR: ";
    for(int i = 0; i < impares.size() ; i++) {
        cout << impares[i] << " ";
    }

    return 0;
}