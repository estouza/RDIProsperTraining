using System;

public class Program
    {
    public static void Main(string[] args)
    {
        Transporte carro = new Carro();
        carro.CustoPorKm = 2.5;
        double custoCarro = carro.CalcularCusto(100);
        Console.WriteLine($"Custo do carro para 100 km: {custoCarro}");


        Transporte bicicleta = new Bicicleta();
        bicicleta.CustoPorKm = 0.0;
        double custoBicicleta = bicicleta.CalcularCusto(100);
        Console.WriteLine($"Custo da bicicleta para 100 km: {custoBicicleta}");


        Transporte onibus = new Onibus();
        onibus.CustoPorKm = 3.5;
        double custoOnibus = onibus.CalcularCusto(100);
        Console.WriteLine($"Custo do ônibus para 100 km: {custoOnibus}");
    }
}