#include <iostream>
#include <iomanip> 
using namespace std;

int main() {
    
    double raio, area;
    const double pi = 3.14159;

    // Entrada
    cout << "Digite o valor do raio: ";
    cin >> raio;

    // Cálculo da área
    area = pi * raio * raio;

    // Saída com 4 casas decimais
    cout << fixed << setprecision(4);
    cout << "AREA = " << area << endl;

    return 0;
}
