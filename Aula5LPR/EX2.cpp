#include <iostream>
#include <random>

using namespace std;

int main()
{
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);

    int chute;
    int tentativas = 0;

    do
    {
        cout << "Digite um numero (1 a 100): ";
        cin >> chute;

        tentativas++;

        if (chute > valorInteiro)
        {
            cout << "Chutou alto!" << endl;
        }
        else if (chute < valorInteiro)
        {
            cout << "Chutou baixo!" << endl;
        }
        else
        {
            cout << "Acertou!" << endl;
        }

    } while (chute != valorInteiro);

    cout << "Voce acertou em " << tentativas << " tentativas!" << endl;

    return 0;
}