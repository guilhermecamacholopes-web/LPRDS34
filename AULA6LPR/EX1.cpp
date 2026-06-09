#include <iostream>
using namespace std;

int reverterNumero(int num)
{
    int reverso = 0;

    while (num != 0)
    {
        int digito = num % 10;      
        reverso = reverso * 10 + digito; 
        num = num / 10;             
    }

    return reverso;
}

int main()
{
    int numero;
    cin >> numero;

    cout << reverterNumero(numero);

    return 0;
}