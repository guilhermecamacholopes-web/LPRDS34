
#include <iostream>
#include <string>
#include <vector>
using namespace std;

class Livro {
private:
    string titulo;
    string autor;
    int anoPublicacao;

public:
    // Construtor
    Livro(string titulo, string autor, int anoPublicacao) {
        this->titulo = titulo;
        this->autor = autor;
        this->anoPublicacao = anoPublicacao;
    }

    // Getters
    string getTitulo() {
        return titulo;
    }

    string getAutor() {
        return autor;
    }

    int getAnoPublicacao() {
        return anoPublicacao;
    }

    // Setters
    void setTitulo(string titulo) {
        this->titulo = titulo;
    }

    void setAutor(string autor) {
        this->autor = autor;
    }

    void setAnoPublicacao(int anoPublicacao) {
        this->anoPublicacao = anoPublicacao;
    }
};

class Biblioteca {
private:
    vector<Livro> livros;

public:
    // Adiciona um livro à biblioteca
    void AdicionarLivro(Livro livro) {
        livros.push_back(livro);
    }

    // Lista todos os livros
    void ListarLivros() {
        for (int i = 0; i < livros.size(); i++) {
            cout << "Titulo: "
                 << livros[i].getTitulo() << endl;

            cout << "Autor: "
                 << livros[i].getAutor() << endl;

            cout << "Ano de publicacao: "
                 << livros[i].getAnoPublicacao() << endl;

            cout << "-------------------" << endl;
        }
    }
};

int main() {
    Biblioteca biblioteca;

    Livro livro1("Dom Casmurro", "Machado de Assis", 1899);
    Livro livro2("O Cortico", "Aluisio Azevedo", 1890);
    Livro livro3("O Pequeno Principe", "Antoine de Saint-Exupery", 1943);

    biblioteca.AdicionarLivro(livro1);
    biblioteca.AdicionarLivro(livro2);
    biblioteca.AdicionarLivro(livro3);

    cout << "=== LIVROS DA BIBLIOTECA ===" << endl;
    biblioteca.ListarLivros();

    return 0;
}
