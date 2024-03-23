// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Propriedades ##");


Produto p01 = new Produto(); // objeto p01


p01.Nome = "Caderno";
p01.Preco = 10.00;
p01.EstoqueMinimo = 10;


p01.Exibir();

Console.ReadKey();

public class Produto
{
    // propriedades
    private string? nome; // campo privado
    public string? Nome 
    {
        get { return nome.ToUpper(); } // alterando que todo dado nome seja letras maiuscula
        set { nome = value;  } 
    }
    private double preco;
    public double Preco {
        get { return preco; } // retorna o valor do preco sem alteração
        set 
        {
            if (value < 5) // validando se é maior ou menor que 5 
            {
                preco = 5.00;
            }
            else
            {
                preco = value;
            }
        } 
    }
    private double desconto = 0.05;
    public double Desconto  // como só tem get então será somente leitura
    {
        get { return desconto; }
    }
    public double PrecoFinal //  como só tem get então será somente leitura
    {
        get {return Preco - (Preco * Desconto); }
    }

    private int minimo;
    public int EstoqueMinimo 
    { 
        set { minimo = value; }
    }


    // metodos
    public void Exibir()
    {
        Console.WriteLine($"{Nome} \n{Preco.ToString("c")} \n{Desconto} +" +
            $" \n{PrecoFinal.ToString("c")} \n{minimo}");
            // Obs esse ToString("c") é formando para moeda local
    }
}

