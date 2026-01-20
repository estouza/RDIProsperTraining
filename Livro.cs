using System;
using System.Collections.Generic;

namespace Livro
{
    public class Livro

    {
        // Atributos
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Status { get; set; } // Disponível, Emprestado
        public string Locatario { get; set; } // quem pegou emprestado


        // Construtor
        public Livro(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
            Status = "Disponível";
            Locatario = string.Empty; // ou ""
        }

        // Métodos
        public void Emprestar(string nomeLocatario)
        {
            Status = "Emprestado";
            Locatario = nomeLocatario;
        }

        public void Devolver()
        {
            Status = "Disponível";
            Locatario = string.Empty;
        }

    }
}
