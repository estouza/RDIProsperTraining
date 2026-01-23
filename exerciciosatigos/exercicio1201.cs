using System;
public class Program
{
	public static void Main()
	{
		int qualTabuada, numero, resultado;
		
		Console.WriteLine("-----TABUADAS DE 1 A 10------");
	
			
		for (qualTabuada = 1; qualTabuada <= 10; qualTabuada++)
		{
			Console.WriteLine("*------------*");
			Console.WriteLine($"Tabuada de {qualTabuada}");
			Console.WriteLine();
			
			for (numero = 1; numero <= 10; numero++)
			{
				
			resultado = qualTabuada * numero;
				
		
			Console.WriteLine($"{qualTabuada} x {numero} = {resultado}");
			
			
			}
		}
	}
}
	
