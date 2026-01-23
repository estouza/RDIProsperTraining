using System;
using System.Collections.Generic;

namespace Livro
{
    public class Pessoa
    {
        // Atributos
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Livro> LivrosEmprestados { get; set; } = new List<Livro>();

        // Construtor
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
           // ou pode fazer aqui LivrosEmprestados = new List<Livro>();
        }
        // Métodos
        public void PegarLivro(Livro livro) // o que tá em parenteses é o que vc vai precisar receber
        {
            LivrosEmprestados.Add(livro); // adicione na minha lista de livros o livro que foi enviado
        }

        public void DevolverLivro(Livro livro)
        {
            LivrosEmprestados.Remove(livro);
        }

    }
}   