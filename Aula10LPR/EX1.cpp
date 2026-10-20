
#include <iostream>
using namespace std;

class Retangulo {
public:
    double Altura;
    double Largura;

    double calcArea() {
        return Altura * Largura;
    }

    double calcPerimetro() {
        return 2 * (Altura + Largura);
    }
};

int main() {
    Retangulo r;

    cout << "Digite a altura do retangulo: ";
    cin >> r.Altura;

    cout << "Digite a largura do retangulo: ";
    cin >> r.Largura;

    cout << "Area: " << r.calcArea() << endl;
    cout << "Perimetro: " << r.calcPerimetro() << endl;

    return 0;
}
