using System;

public interface IVeiculo
{
    void Dirigir();
    bool Reabastecer(int quantidade);
}

public class Carro : IVeiculo
{
    private int gasolina;

    public Carro(int quantidadeInicialGasolina)
    {
        gasolina = quantidadeInicialGasolina;
    }

    public void Dirigir()
    {
        if (gasolina > 0)
        {
            Console.WriteLine("Dirigindo");
        }
        else
        {
            Console.WriteLine("Sem gasolina, não é possível dirigir.");
        }
    }

    public bool Reabastecer(int quantidade)
    {
        if (quantidade > 0)
        {
            gasolina += quantidade;
            Console.WriteLine($"Reabastecido com sucesso. Gasolina atual: {gasolina}");
            return true;
        }
        else
        {
            Console.WriteLine("Quantidade inválida de gasolina para reabastecer.");
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro(20);

        meuCarro.Dirigir();

        meuCarro.Reabastecer(10);

        meuCarro.Dirigir();

        meuCarro.Reabastecer(-5);

        meuCarro.Dirigir();

        meuCarro.Reabastecer(0);
    }
}
