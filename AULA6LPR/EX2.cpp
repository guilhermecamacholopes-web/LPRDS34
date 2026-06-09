#include <iostream>
using namespace std;

int somaAteN(int n)
{
    int soma = 0;
    for (int i = 1; i <= n; i++)
    {
        soma += i;
    }
    return soma;
}

int contarPares(int n)
{
    int contador = 0;
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
            contador++;
    }
    return contador;
}

int fatorial(int n)
{
    int resultado = 1;
    for (int i = 1; i <= n; i++)
    {
        resultado *= i;
    }
    return resultado;
}

int main()
{
    int opcao, n;

    do
    {
        cout << "\n===== MENU =====\n";
        cout << "1 - Soma de 1 ate N\n";
        cout << "2 - Contar numeros pares ate N\n";
        cout << "3 - Fatorial de N\n";
        cout << "0 - Sair\n";
        cout << "Escolha: ";
        cin >> opcao;

        if (opcao >= 1 && opcao <= 3)
        {
            cout << "Digite um numero: ";
            cin >> n;
        }

        switch (opcao)
        {
        case 1:
            cout << "Resultado: " << somaAteN(n) << endl;
            break;

        case 2:
            cout << "Resultado: " << contarPares(n) << endl;
            break;

        case 3:
            cout << "Resultado: " << fatorial(n) << endl;
            break;

        case 0:
            cout << "Encerrando...\n";
            break;

        default:
            cout << "Opcao invalida!\n";
        }

    } while (opcao != 0);

    return 0;
}
