using System;

public class Onibus	 : Transporte
{
    public override double CalcularCusto(double distancia)
    {
        return CustoPorKm * distancia;
    }
}
