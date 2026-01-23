using System;
using System.Collections.Generic;

namespace DemoTiposDeDados
{
    // Classe de demonstração
    public class Programa
    {
        // Ponto de entrada do console application
        public static void Main(string[] args)
        {
            // 1 criar a lista
            List<int> numeros = new List<int>();
            
            //Adicionar números
            numeros.Add(10); 
            numeros.Add(20);
            numeros.Add(30);

            //Imprimir usando foreach
            Console.WriteLine("Números iniciais");
            foreach (var num in numeros)  // ao invés daquela estrutura do for int 1 = 0; i< lista.Count; i++)
            {//essa é minha lista, percorre ela aí -> é o que essa estrutura diz (PORÉM VOCÊ TEM MENOS CONTROLE SOBRE ELE, COMO A CAMI DISSE)
                Console.WriteLine(num);
            }
            
            //Atualizar para 50
            numeros[1] = 50;

            //Atualizar o número 10 para 5 usando IndexOf
            int index = numeros.IndexOf(10); //vc nao sabe o índice, mas sabe o valor -> quer saber o índice daquele valor ("qual o índice do 10?")
            if (index != -1)
            {
                numeros[index] = 5;
            }
           
            // Remover o 30
            numeros.Remove(30);

            //Reimprimir
            Console.WriteLine("Números após atualizações:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
            
            //Mostrar a quantidade de itens
            Console.WriteLine($"\nQuantidade de itens na lista: {numeros.Count}");

        }

           
     }
 }
