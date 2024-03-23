// See https://aka.ms/new-console-template for more information
Console.WriteLine("## Campos Estáticos - Execicio");

// criando um objeto conta01 
ContaCorrente conta01 = new ContaCorrente();

conta01.Conta = 101;
conta01.Nome = "Maria";
//conta01.Juros = 3.99f;

// criando um objeto conta02 
ContaCorrente conta02 = new ContaCorrente();

conta02.Conta = 102;
conta02.Nome = "Marta";
//conta02.Juros = 4.99f;


// como Juros é um atributo estatico se altera direto na classe
// não da para cada objeto ter um valor diferente de juros 
ContaCorrente.Juros = 4.25f;


Console.WriteLine($"Cliente : {conta01.Nome} - Juros Anual : {conta01.JurosAnual()}");
Console.WriteLine($"Cliente : {conta02.Nome} - Juros Anual : {conta02.JurosAnual()}");


Console.ReadKey();


public class ContaCorrente
{
    // atributos
    public int Conta;
    public string? Nome;
    public static float Juros; // atributo estatico

    // métodos
    public float JurosAnual()
    {
        return Juros * 12;
    }
}