using System;

class Animal
{
    // Método virtual — pode ser sobrescrito nas classes filhas
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som...");
    }
}

class Cachorro : Animal
{
    // Sobrescreve o método da classe pai
    public override void FazerSom()
    {
        Console.WriteLine("Au au!");
    }
}

class Gato : Animal
{
    // Sobrescreve o método da classe pai
    public override void FazerSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criação dos objetos
        Animal cachorro = new Cachorro();
        Animal gato = new Gato();

        // Chamando o método sobrescrito em cada um
        cachorro.FazerSom(); // Saída: Au au!
        gato.FazerSom();     // Saída: Miau!
    }
}
