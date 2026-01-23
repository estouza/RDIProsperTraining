using System;

	public abstract class Transporte
	{
		public double CustoPorKm {get; set; } 
		public void Mover() 
		{
			Console.WriteLine("Esse meio de transporte se move"); // todas as classes filha herdam esse comportamento - todos os transportes se movem né bb
		}
		public abstract double CalcularCusto(double distancia); // não tem corpo, quem decide são os filhos
	}

