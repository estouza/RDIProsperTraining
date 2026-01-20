using System;
using System.Collections.Generic;

namespace Livro
{
    public class Biblioteca
    { 
        public List<Livro> Livros { get; set; } = new List<Livro>();
        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>(); 

        //MÉTODOS

        //Cadastrar os livros
        public void CadastrarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        //Cadastras as pessoinhas
        public void CadastrarUsuario(Pessoa pessoa) //entre parenteses a gente chama de parametro, o que a gente vai chamar, tanto o parametro como o objeto a gente pode dar o nome que quiser
        {
            Pessoas.Add(pessoa);
        }

        
        //Listar os livros
        public void ListarLivros()
        {
            foreach (Livro livro in Livros)  //para cada item em livros
            {
                Console.WriteLine($"ID: {livro.Id} - Título: {livro.Titulo} - Status: {livro.Status}");
            }
        }

        //Emprestar livros

        public void EmprestarLivros(Livro livro, Pessoa pessoa)
        {
           livro.Emprestar(pessoa.Nome); // altera o nome para emprestado
            pessoa.PegarLivro(livro);
        }

        //Devolver livros
        public void DevolverLivros(Livro livro, Pessoa pessoa)
        {
            livro.Devolver();
            pessoa.DevolverLivro(livro);
        }

        public Livro BuscarLivroPorId(int id)
        {
            foreach (Livro livro in Livros)
            {
                return livro;
            }
            return null;
        }
    }
}