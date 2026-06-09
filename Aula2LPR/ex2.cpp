#include <iostream>

using namespace std;

int main() {
    
    int numA,numB,numC,numD;
    int resultado;

    
    cout << "Digite o valor do primeiro numero: ";
    cin >> numA;

     cout << "Digite o valor do segundo numero: ";
     cin >> numB;
    
      cout << "Digite o valor do terceiro numero: ";
     cin >> numC;
    
     cout << "Digite o valor do quarto numero: ";
     cin >> numD;
    
    
     
     // Cálculo entre os numeros
    resultado = (numA * numB) - (numC * numD) ;

    cout << "Resultado = " << resultado << endl;

    return 0;
}
