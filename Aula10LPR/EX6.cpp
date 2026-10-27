
#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Cliente;

class Reserva {
public:
    string descricao;
    Cliente* cliente;

    Reserva(string descricao) {
        this->descricao = descricao;
        cliente = nullptr;
    }
};

class Cliente {
public:
    string nome;
    vector<Reserva*> reservas;

    Cliente(string nome) {
        this->nome = nome;
    }

    // Adiciona uma reserva ao cliente
    void adicionarReserva(Reserva* reserva) {
        reservas.push_back(reserva);
        reserva->cliente = this;
    }

    // Lista todas as reservas do cliente
    void listarReservas() {
        cout << "Reservas do cliente: " << nome << endl;

        for (Reserva* reserva : reservas) {
            cout << "Reserva: " << reserva->descricao << endl;
        }
    }
};

int main() {
    Cliente cliente1("Joao");

    Reserva r1("Reserva 001");
    Reserva r2("Reserva 002");
    Reserva r3("Reserva 003");

    cliente1.adicionarReserva(&r1);
    cliente1.adicionarReserva(&r2);
    cliente1.adicionarReserva(&r3);

    cliente1.listarReservas();

    return 0;
}
