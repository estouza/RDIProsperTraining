using System;

public class Cachorro : Animal
{
    public string Raca { get; set; }

    public Cachorro(string nome, string raca) : base(nome)
    {
        Raca = raca;
    }

    public override string EmitirSom()
    {
        return "AuAu";
    }
}
