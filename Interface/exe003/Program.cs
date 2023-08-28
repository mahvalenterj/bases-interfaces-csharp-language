using System;

public interface G1
{
    void mymethod();
}

public interface G2
{
    void mymethod();
}

public class Geeks : G1, G2
{
    void G1.mymethod()
    {
        // Implementação para G1
        Console.WriteLine("Implementação para G1");
    }

    void G2.mymethod()
    {
        // Implementação para G2
        Console.WriteLine("Implementação para G2");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Geeks geeks = new Geeks();
        ((G1)geeks).mymethod(); // Chamando a implementação de G1
        ((G2)geeks).mymethod(); // Chamando a implementação de G2
    }
}
