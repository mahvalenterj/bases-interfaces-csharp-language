using System;

public interface IAnimal
{
    void Comer();
    void Dormir();
}

public class Cachorro : IAnimal
{
    public void Comer()
    {
        Console.WriteLine("O cachorro está comendo.");
    }

    public void Dormir()
    {
        Console.WriteLine("O cachorro está dormindo.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro();
        cachorro.Comer();
        cachorro.Dormir();
    }
}
