Console.WriteLine("--Cachorro");

Cachorro Nelson = new Cachorro("Nelson", "Raça Indefinida");
Console.WriteLine(Nelson.Nome);
Console.WriteLine(Nelson.Raca);
Console.WriteLine(Nelson.EmitirSom());
Console.WriteLine($"----{Nelson.Nome} faz {Nelson.EmitirSom()}----");

Console.WriteLine("--Girafa");
Animal animalindefinido = new Animal("Girafa");
Console.WriteLine(animalindefinido.EmitirSom());
Console.WriteLine($"----{animalindefinido.Nome} faz {animalindefinido.EmitirSom()}----");

Console.WriteLine("--Gato");
Gato miau = new Gato("Drácula");
Console.WriteLine(miau.Nome);
Console.WriteLine(miau.EmitirSom());
Console.WriteLine($"----{miau.Nome} faz {miau.EmitirSom()}----");

// Outro exercício 
/* using System;
using System.Collections.Generic;

List<Animal> animais = new List<Animal>();

animais.Add(new Cachorro("Pipoca"));
animais.Add(new Gato("Luna"));

foreach (Animal animal in animais)
{
    Console.WriteLine($"{animal.Nome} faz {animal.EmitirSom()}");
}
*/
