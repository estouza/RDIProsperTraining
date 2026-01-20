using System;
using System.Reflection.Metadata;
namespace Livro
{
class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            
            //Cadastrar algumas ops pra poder escolher
            biblioteca.CadastrarLivro(new Livro(1, "Frankenstein"));
            biblioteca.CadastrarLivro(new Livro(2, "Coraline"));
            biblioteca.CadastrarLivro(new Livro(3, "Trono de Vidro"));
            
            bool sair = false;

            while (!sair)
            {

            Console.WriteLine("\n--------Bem-vindes à Biblioteca da Meia-Noite!-------\n");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Listar todos os livros");
            Console.WriteLine("2 - Emprestar Livro");
            Console.WriteLine("3 - Devolver Livro");
            Console.WriteLine("4 - Sair");

            int opcaoEscolhida = int.Parse(Console.ReadLine() ?? "0");

            if (opcaoEscolhida == 1)
            {
                biblioteca.ListarLivros();
                
            }
               else if (opcaoEscolhida == 2)
                {    
                    Console.WriteLine("Digite o nome do locatário: ");
                    string nomePessoa = Console.ReadLine(); 

                    Pessoa pessoaCadastrada = new Pessoa(1, nomePessoa);
                    biblioteca.CadastrarUsuario(pessoaCadastrada);

                    Console.WriteLine("\nPor favor, escolha o livro desejado, por ID:\n");
                    Console.WriteLine("1 - Frankenstein");
                    Console.WriteLine("2 - Coraline");
                    Console.WriteLine("3 - Trono de Vidro");
                    int idLivroEscolhido = int.Parse(Console.ReadLine()?? "0");


                    Livro livroEscolhido = biblioteca.BuscarLivroPorId(idLivroEscolhido);

                    if(livroEscolhido == null)
                    {
                        Console.WriteLine("Livro não encontrado, amore :(");
                    }
                        else
                        {               
                            biblioteca.EmprestarLivros(livroEscolhido, pessoaCadastrada);
                            Console.WriteLine("Empréstimo realizado!");
                            Console.WriteLine($"Livro: {livroEscolhido.Titulo} -- Status: {livroEscolhido.Status} - Locatário: {livroEscolhido.Locatario}");  
                        }    
                            
                            }
                            else if (opcaoEscolhida == 3)
                            {
                                Console.WriteLine("Digite o nome do locatário: ");
                                string nomePessoa = Console.ReadLine() ?? "";

                                Pessoa pessoaCadastrada = new Pessoa(1, nomePessoa);
                                biblioteca.CadastrarUsuario(pessoaCadastrada);

                                Console.WriteLine("Por favor, escolha o livro a ser devolvido, por ID: ");
                                biblioteca.ListarLivros();

                                int idLivroEscolhido = int.Parse(Console.ReadLine() ?? "0");
                                Livro livroEscolhido = biblioteca.BuscarLivroPorId(idLivroEscolhido);
                                if (livroEscolhido == null)
                                {
                                    Console.WriteLine("Livro não encontrado, amore :(");    
                                }
                                else
                                {
                                        biblioteca.DevolverLivros(livroEscolhido, pessoaCadastrada);
                                        Console.WriteLine("Devolução realizada!");
                                        Console.WriteLine($"Livro: {livroEscolhido.Titulo} -- Status: {livroEscolhido.Status} - Locatário: {livroEscolhido.Locatario}");
                                }                        

                                 Console.WriteLine("Opção Inválida.");

                                }    
                                 else if (opcaoEscolhida == 3)
                                {
                                    Console.WriteLine("Saindo...");
                                    sair = true;
                            
                            }

            } 
        }
    }
}
//ou 
// using System;
// Livro livro1 = new Livro(1, "Dom Casmurro");
// Console.WriteLine($"{livro1.Titulo} - Status do livro: {livro1.Status}");
// livro1.Emprestar("João Silva");
// Console.WriteLine($"{livro1.Titulo} - Status do livro: {livro1.Status} - Locatário: {livro1.Locatario}");
// livro1.Devolver();
// Console.WriteLine($"{livro1.Titulo} - Status do livro: {livro1.Status} - Locatário: {livro1.Locatario}");
