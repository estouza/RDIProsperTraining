using System;

public class Carro : Transporte
{
	public override double CalcularCusto(double distancia)
	{
		return CustoPorKm * distancia;
	}
}
