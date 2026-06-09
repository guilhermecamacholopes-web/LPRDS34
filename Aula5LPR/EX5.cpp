#include <iostream>
using namespace std;

int main()
{
    double horas;
    cout << "Treinamento Jedi";
     
    cout << "  Insira o numero de horas de treinamento por dia : ";
    cin >> horas;

    double horasSemana = horas * 5; 
    double totalHoras = 0;
    int semanas = 0;

    while (totalHoras < 1000)
    {
        totalHoras += horasSemana;
        semanas++;
    }

    int dias = semanas * 5;
    double meses = semanas / 4.5;

    cout << "\nTotal de horas: " << totalHoras << endl;
    cout << "Dias de treino: " << dias << endl;
    cout << "Semanas: " << semanas << endl;
    cout << "Meses: " << meses << endl;

    return 0;
}