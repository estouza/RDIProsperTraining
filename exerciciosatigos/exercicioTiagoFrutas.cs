using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ----- array (tamanho fixo) -----
        string[] frutas = new string[3]; 
        frutas[0] = "Kiwi";
        frutas[1] = "Melancia";
        frutas[2] = "Cupuaçu";

            Console.WriteLine("array - Frutas (tamanho fixo):");
                for (int i = 0; i < frutas.Length; i++)
                {
                    Console.WriteLine(frutas[i]); //dá pra ser assim
                }
            
        frutas[0] = "Pera - Atualizado"; //faz isso para atualizar o valor do índice 1 e aí repete o for, que é o "chato"

          Console.WriteLine("Array - Após atualizar índice 1 para 'Pera':");
           
                for (int i = 0; i < frutas.Length; i++)
                {
                    Console.WriteLine($" indice {i}: {frutas[i]}"); //ou assim
                }

                Console.WriteLine();





    }

}