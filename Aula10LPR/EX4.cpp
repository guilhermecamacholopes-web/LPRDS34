
#include <iostream>
#include <string>
using namespace std;

class Arma {
public:
    string nome;
    int dano;

    void atacar() {
        cout << nome << " causou "
             << dano << " de dano!" << endl;
    }

    void melhorarDano(int valor) {
        dano += valor;
    }
};

class Inimigo {
public:
    string nome;
    int vida;
    int dano;

    void atacar() {
        cout << nome << " atacou e causou "
             << dano << " de dano!" << endl;
    }

    void receberDano(int valor) {
        vida -= valor;

        if (vida < 0) {
            vida = 0;
        }

        cout << nome << " agora tem "
             << vida << " de vida." << endl;
    }
};

class Jogador {
public:
    string nome;
    int vida;
    int nivel;

    void atacar() {
        cout << nome << " esta atacando!" << endl;
    }

    void receberDano(int valor) {
        vida -= valor;

        if (vida < 0) {
            vida = 0;
        }
    }

    void usarArma(Arma &arma, Inimigo &inimigo) {
        cout << nome << " usou " << arma.nome << "!" << endl;
        inimigo.receberDano(arma.dano);
    }
};

int main() {
    Jogador jogador;
    jogador.nome = "Steve";
    jogador.vida = 100;
    jogador.nivel = 1;

    Arma arma;
    arma.nome = "Espada de Ferro";
    arma.dano = 25;

    Inimigo inimigo;
    inimigo.nome = "Zumbi";
    inimigo.vida = 50;
    inimigo.dano = 10;

    jogador.atacar();
    jogador.usarArma(arma, inimigo);

    return 0;
}
