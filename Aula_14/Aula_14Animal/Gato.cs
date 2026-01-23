using System;

public class Gato : Animal
{
    public Gato(string nome) : base(nome)
    {                         // se o pai tem construtor, os filhos tbm
    }

    public override string EmitirSom()
    {
        return "Miau";
    }
}

