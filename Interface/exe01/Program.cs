using System;

public interface IData
{
    void setData(DateTime data);
    DateTime getData();
    string dataString();
}

public class Produto : IData
{
    public string nome;
    public decimal valor;
    private DateTime data;

    public void setData(DateTime data)
    {
        this.data = data;
    }

    public DateTime getData()
    {
        return data;
    }

    public string dataString()
    {
        return data.ToString("dd/MM/yyyy");
    }
}

public class Venda : IData
{
    public Produto produto;
    private DateTime data;

    public void setData(DateTime data)
    {
        this.data = data;
    }

    public DateTime getData()
    {
        return data;
    }

    public string dataString()
    {
        return data.ToString("dd/MM/yyyy");
    }
}

public static class TestarVenda
{
    public static string DetalhesVenda(Venda venda)
    {
        return $"Data da venda: {venda.getData().ToString("dd/MM/yyyy")} - Produto: {venda.produto.nome} - Valor do produto: {venda.produto.valor} - Vencimento: {venda.produto.dataString()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();
        produto.nome = "Leite Integral";
        produto.valor = 5;
        produto.setData(new DateTime(2023, 3, 1));

        Venda venda = new Venda();
        venda.produto = produto;
        venda.setData(DateTime.Now);

        string detalhesVenda = TestarVenda.DetalhesVenda(venda);
        Console.WriteLine(detalhesVenda);
    }
}

