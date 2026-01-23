using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

    int quantidadeDeFrutas = 3;
    double precoMedio = 2.50;
    bool estoqueDisponivel = true;
    string mensagem = "Bem-vindo ao programa de frutas!";

    
        Console.WriteLine("=== Exemplo: Tipos de Dados em C# ===\n");

        // Tipo inteiro
        Console.WriteLine($"Quantidade de frutas: {quantidadeDeFrutas}");
        // Tiago fez assim: Console.WriteLine("Quantidade de frutas: " + quantidadeFrutas);


        // Tipo ponto flutuante
        Console.WriteLine($"Preço médio por fruta: R$ {precoMedio}");

        // Tipo booleano
        Console.WriteLine($"Estoque disponível? :{estoqueDisponivel}");

        // Tipo string
        Console.WriteLine(mensagem);

       int soma = quantidadeDeFrutas + 2;
       
       precoMedio = precoMedio * 1.1;

       estoqueDisponivel =!estoqueDisponivel;

       mensagem = mensagem + " Aproveite nossas ofertas!";

        //Impressões após alterações
        Console.WriteLine("Quantidade de frutas: " + quantidadeDeFrutas);
        Console.WriteLine("Preço médio: R$ " + precoMedio.ToString("F2"));
        Console.WriteLine("Estoque disponível? " + estoqueDisponivel);
        Console.WriteLine(mensagem);

      
    }
    }
